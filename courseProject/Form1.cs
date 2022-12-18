using System;
using System.Collections.Generic;
using System.Windows.Forms;

/*
    Расчёт и визуализация расстояния Левенштейна
            Пользователь вводит две фразы - начальную и конечную. Программа
        рассчитывает расстояние Левенштейна между ними и выводит как его
        значение, так и все операции, которые необходимо провести в виде списка или
        графически.
 */
namespace courseProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private static int Minimum(int a, int b, int c) => (a = a < b ? a : b) < c ? a : c;
        
        private static int[,] LevenshteinDistance(string firstWord, string secondWord)
        { 
            var n = firstWord.Length + 1;
            var m = secondWord.Length + 1;
            var matrixD = new int[n, m];

            const int deletionCost = 1;
            const int insertionCost = 1;

            for (var i = 0; i < n; i++)
            {
                matrixD[i, 0] = i;
            }

            for (var j = 0; j < m; j++)
            {
                matrixD[0, j] = j;
            }

            for (var i = 1; i < n; i++)
            {
                for (var j = 1; j < m; j++)
                {
                    var substitutionCost = firstWord[i - 1] == secondWord[j - 1] ? 0 : 1;

                    matrixD[i, j] = Minimum(matrixD[i - 1, j] + deletionCost,          // удаление
                        matrixD[i, j - 1] + insertionCost,         // вставка
                        matrixD[i - 1, j - 1] + substitutionCost); // замена
                }
            }
            
            
            return matrixD;
        }

        private static List<string> get_Path(int[,] matrixD, string firstWord, string secondWord)
        {
            var n = firstWord.Length + 1;
            var m = secondWord.Length + 1;
            List<string> path = new List<string>();
            int index1 = n - 1, index2 = m - 1, current = matrixD[n - 1, m - 1];
            while ((index1 != 0) && (index2 != 0))
            {
                int temp = Minimum(matrixD[index1 - 1, index2],        
                    matrixD[index1, index2 - 1],         
                    matrixD[index1 - 1, index2 - 1] );
                if (current == temp) 
                    current = matrixD[index1--, index2--];
                else
                {
                    if (temp == matrixD[index1 - 1, index2])
                    {
                        path.Add("Удалить символ \"" + firstWord[index1 - 1] + '\"');
                        current = temp;
                        index1--;
                        continue;
                    }
                    if (temp == matrixD[index1, index2 - 1])
                    {
                        path.Add("Вставить символ \"" + secondWord[index2 - 1] + "\" на позицию " + index2);
                        current = temp;
                        index2--;
                        continue;
                    }

                    if (temp == matrixD[index1 - 1, index2 - 1])
                    {
                        path.Add("Заменить символ \"" + firstWord[index1 - 1] + "\" на символ \"" + secondWord[index2 - 1] + "\"");
                        current = temp;
                        index1--; index2--;
                    }
                }
            }
            path.Reverse();
            return path;
        }
        
        private void button1_Click_1(object sender, EventArgs e)
        {
            var levenshteinDistance = LevenshteinDistance(firstLine.Text, secondLine.Text);
            label3.Text = @"Расстояния Левенштейна: " + levenshteinDistance[firstLine.Text.Length, secondLine.Text.Length] + '\n';
            var path = get_Path(levenshteinDistance, firstLine.Text, secondLine.Text);
            foreach (var pth in path)
                label3.Text += pth + '\n';
            //levenshtein
            //meilenstein
        }
    }
}
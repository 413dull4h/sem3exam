using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam16
{
    public class Class1
    {
        static public double Det(double[,] mas, int razmer)
        {

            if (razmer == 2)
            {
                return (mas[0, 0] * mas[1, 1] - mas[0, 1] * mas[1, 0]);
            }
            else if (razmer == 1)
            {
                return (mas[0, 0]);
            }
            else if (razmer >= 3)
            {
                double det = 0;
                int a, b;
                double[,] newA = new double[razmer - 1, razmer - 1];
                for (int i = 0; i < razmer; i++)
                {
                    a = 0;
                    for (int j = 1; j < razmer; j++)
                    {
                        b = 0;
                        for (int c = 0; c < razmer; c++)
                        {
                            if (c != i)
                            {
                                newA[a, b] = mas[j, c];
                                b++;
                            }
                        }
                        a++;
                    }
                    det += Math.Pow(-1, i + 2) * mas[0, i] * Det(newA, razmer - 1);

                }
                return det;
            }
            return 0;
        }
        static public double UnionMatrix(double[,] mas, int num1, int num2, int razmer)
        {
            double[,] podmass = new double[razmer - 1, razmer - 1];
            int indI = num1;
            int indB = num2;
            int s = 0;
            int s1 = 0;
            for (int ind1 = 0; ind1 < razmer; ind1++)
            {
                if (ind1 != indI)
                {
                    s1 = 0;
                    for (int ind2 = 0; ind2 < razmer; ind2++)
                    {
                        if (ind2 != indB)
                        {
                            podmass[s, s1] = mas[ind1, ind2];
                            s1++;
                        }
                    }
                    s++;
                }
            }
            return Math.Pow(-1, indB + indI + 2) * Det(podmass, razmer - 1);
        }
    }
}

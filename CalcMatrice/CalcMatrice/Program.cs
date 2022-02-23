using System;

namespace CalcMatrice
{

    class Program
    {
        static void addMatrice(int[,] M1, int[,] M2, out int[,] Mr)
        {
            Mr = new int[2, 5];
            if (M1.GetLength(1) == M2.GetLength(1) && M1.GetLength(0) == M2.GetLength(0))
            {
                for (int n = 0; n < M1.GetLength(0); n++)
                {
                    for (int i = 0; i < M2.GetLength(1); i++)
                    {
                        Mr[n, i] = M1[n, i] + M2[n, i];
                    }
                }
            }
        }

        static void displayMr(int[,] Mr, out string result)
        {
            result = "";
            for (int n = 0; n < Mr.GetLength(0); n++)
            {
                result = result + '\n';
                for (int i = 0; i < Mr.GetLength(1); i++)
                {
                    result = result + Mr[n, i];
                }
            }
        }

        static void multiMatrice(int[,] Mmulti1, int[,] Mmulti2, out int[,] Mresult)
        {
            Mresult = new int[Mmulti1.GetLength(0), Mmulti2.GetLength(1)];
            int nbrColonnes = Mmulti2.GetLength(0);

            if (Mmulti1.GetLength(1) == Mmulti2.GetLength(0))
            {
                for (int n = 0; n < Mresult.GetLength(0); n++)
                {
                    for (int i = 0; i < Mresult.GetLength(1); i++)
                    {
                        for (int k = 0; k < nbrColonnes; k++)
                        {
                            Mresult[n, i] = Mresult[n, i] + Mmulti1[n, k] * Mmulti2[k, i];
                        }
                    }
                }
            }
        }

        static void displayMrmulti(int[,] Mresult, out string resultMulti)
        {
            resultMulti = "";
            for (int n = 0; n < Mresult.GetLength(0); n++)
            {
                resultMulti = resultMulti + '\n';
                for (int i = 0; i < Mresult.GetLength(1); i++)
                {
                    resultMulti = resultMulti + Mresult[n, i];
                }
            }
        }


        static void Main(string[] args)
        {
            int choix;
            Console.WriteLine("Selectionner une procédure !\n\n 1) addition de matrices \n 2) multiplication de matrices");
            choix = int.Parse(Console.ReadLine());

            switch(choix){
                case 1:
                    int[,] M1 = { { 10, 12, 13, 22, 25 }, { 5, 7, 8, 10, 12 } };
                    int[,] M2 = { { 10, 12, 13, 22, 25 }, { 5, 7, 8, 10, 12 } };
                    int[,] Mr;
                    string result;

                    addMatrice(M1, M2, out Mr);
                    displayMr(Mr, out result);

                    Console.WriteLine(result);
                    Console.ReadLine();
                   
                    break;

                case 2:
                    int[,] Mmulti1 = { { 10, 12 }, { 5, 7 }, { 5, 7 } };
                    int[,] Mmulti2 = { { 10, 12, 13, 22 }, { 5, 7, 8, 10 } };
                    int[,] Mresult;
                    string resultMulti;

                    multiMatrice(Mmulti1, Mmulti2, out Mresult);
                    displayMrmulti(Mresult, out resultMulti);

                    Console.WriteLine(resultMulti);
                    Console.ReadLine();
                    break;
            };
            
        }
    }
}

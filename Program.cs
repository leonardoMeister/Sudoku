using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    class Program
    {
        int[,] matrixSudoku = new int[9,9];
        int simNao = 0;


        public Program()
        {
            String sudoku = @"1 3 2 5 7 9 4 6 8
                              4 9 8 2 6 1 3 7 5
                              7 5 6 3 8 4 2 1 9
                              6 4 3 1 5 8 7 9 2
                              5 2 1 7 9 3 8 4 6
                              9 8 7 4 2 6 5 3 1
                              2 1 4 9 3 5 6 8 7
                              3 6 5 8 1 7 9 2 4
                              8 7 9 6 4 2 1 5 3 ";
            CriarMatriz(sudoku);

            ValidandoLinhasColunas();
            criarValidarBlocos();
            
            if (simNao > 0)
            {
                Console.WriteLine("Não");
            }
            else if (simNao == 0)
            {
                Console.WriteLine("Sim");
            }

            Console.Read();
        }

        private void CriarMatriz(string sudoku)
        {
            using (StringReader sudokuReader = new StringReader(sudoku))
            {
                string linhaSudoku = "";

                for (int x = 0; x < 9; x++)
                {
                    linhaSudoku = sudokuReader.ReadLine();

                    string[] valores = linhaSudoku.Trim().Split();

                    for (int y = 0; y < 9; y++)
                    {
                        matrixSudoku[x, y] = Convert.ToInt32(valores[y]);
                    }
                }
            }
        }

        public int validar(int[] bloco)
        {
            if (bloco[0] == bloco[1] || bloco[0] == bloco[2] || bloco[0] == bloco[3] || bloco[0] == bloco[4] || bloco[0] == bloco[5] || bloco[0] == bloco[6] || bloco[0] == bloco[7] || bloco[0] == bloco[8]
                || bloco[1] == bloco[2] || bloco[1] == bloco[3] || bloco[1] == bloco[4] || bloco[1] == bloco[5] || bloco[1] == bloco[6] || bloco[1] == bloco[7] || bloco[1] == bloco[8]
                || bloco[2] == bloco[3] || bloco[2] == bloco[4] || bloco[2] == bloco[5] || bloco[2] == bloco[6] || bloco[2] == bloco[7] || bloco[2] == bloco[8]
                || bloco[3] == bloco[4] || bloco[3] == bloco[5] || bloco[3] == bloco[6] || bloco[3] == bloco[7] || bloco[3] == bloco[8]
                || bloco[4] == bloco[5] || bloco[4] == bloco[6] || bloco[4] == bloco[7] || bloco[4] == bloco[8]
                || bloco[5] == bloco[6] || bloco[5] == bloco[7] || bloco[5] == bloco[8]
                || bloco[6] == bloco[7] || bloco[6] == bloco[8]
                || bloco[7] == bloco[8]) return 1;
            return 0;
        }

        private void criarValidarBlocos()
        {
           int[] bloco1 = new int[9];
            
            int aux ;

            aux = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int f = 0; f < 3; f++)
                {
                    bloco1[aux] = matrixSudoku[i, f];
                    aux++;
                }
            }
            simNao += validar(bloco1);

            aux = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int f = 0; f < 3; f++)
                {
                    bloco1[aux] = matrixSudoku[i + 3, f];
                    aux++;
                }
            }
            simNao += validar(bloco1);

            aux = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int f = 0; f < 3; f++)
                {
                    bloco1[aux] = matrixSudoku[i + 6, f];
                    aux++;
                }
            }
            simNao += validar(bloco1);

            aux = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int f = 0; f < 3; f++)
                {
                    bloco1[aux] = matrixSudoku[i, f + 3];
                    aux++;
                }
            }
            simNao += validar(bloco1);

            aux = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int f = 0; f < 3; f++)
                {
                    bloco1[aux] = matrixSudoku[i, f + 6];
                    aux++;
                }
            }
            simNao += validar(bloco1);

            aux = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int f = 0; f < 3; f++)
                {
                    bloco1[aux] = matrixSudoku[i + 3, f + 3];
                    aux++;
                }
            }
            simNao += validar(bloco1);

            aux = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int f = 0; f < 3; f++)
                {
                    bloco1[aux] = matrixSudoku[i + 3, f + 6];
                    aux++;
                }
            }
            simNao += validar(bloco1);

            aux = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int f = 0; f < 3; f++)
                {
                    bloco1[aux] = matrixSudoku[i + 6, f + 3];
                    aux++;
                }
            }
            simNao += validar(bloco1);

            aux = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int f = 0; f < 3; f++)
                {
                    bloco1[aux] = matrixSudoku[i + 6, f + 6];
                    aux++;
                }
            }
            simNao += validar(bloco1);
        }

        private void ValidandoLinhasColunas()
        {
            for (int d = 0; d < 9; d++)
            {
                int[] blocoLinha = new int[9];
                int[] blocoColuna = new int[9];

                for (int f = 0; f < 9; f++)
                {  
                    blocoLinha[f] = matrixSudoku[f, d];     
                }

                for (int f = 0; f < 9; f++)
                {
                    blocoColuna[f] = matrixSudoku[d, f];
                }

                simNao += validar(blocoColuna);
                simNao += validar(blocoLinha);
            }
        }

        static void Main(string[] args)
        {
            new Program();
        }
    }
}

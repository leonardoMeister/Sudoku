using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    class Program
    {
        int[] linha1;
        int[] linha2;
        int[] linha3;
        int[] linha4;
        int[] linha5;
        int[] linha6;
        int[] linha7;
        int[] linha8;
        int[] linha9;

        int[] bloco1;
        int[] bloco2;
        int[] bloco3;
        int[] bloco4;
        int[] bloco5;
        int[] bloco6;
        int[] bloco7;
        int[] bloco8;
        int[] bloco9;

        int[,] matrixSudoku;
        int simNao = 0;


        public Program()
        {
            linha1 = PegarArrayUsuario("1 3 2 5 7 9 4 6 8");
            linha2 = PegarArrayUsuario("4 9 8 2 6 1 3 7 5");
            linha3 = PegarArrayUsuario("7 5 6 3 8 4 2 1 9");
            linha4 = PegarArrayUsuario("6 4 3 1 5 8 7 9 2");
            linha5 = PegarArrayUsuario("5 2 1 7 9 3 8 4 6");
            linha6 = PegarArrayUsuario("9 8 7 4 2 6 5 3 1");
            linha7 = PegarArrayUsuario("2 1 4 9 3 5 6 8 7");
            linha8 = PegarArrayUsuario("3 6 5 8 1 7 9 2 4");
            linha9 = PegarArrayUsuario("8 7 9 6 4 2 1 5 3");
            //criando matriz
            matrixSudoku = criarMatriz();
            //validando Colunas
            ValidarColunas();
            //validando Linhas
            simNao += validar(linha1);
            simNao += validar(linha2);
            simNao += validar(linha3);
            simNao += validar(linha4);
            simNao += validar(linha5);
            simNao += validar(linha6);
            simNao += validar(linha7);
            simNao += validar(linha8);
            simNao += validar(linha9);
            //Criando Blocos
            criarBlocos();
            //validando Blocos
            simNao += validar(bloco1);
            simNao += validar(bloco2);
            simNao += validar(bloco3);
            simNao += validar(bloco4);
            simNao += validar(bloco5);
            simNao += validar(bloco6);
            simNao += validar(bloco7);
            simNao += validar(bloco8);
            simNao += validar(bloco9);

            if (simNao>0)
            {
                Console.WriteLine("Não");
            }else if (simNao==0)
            {
                Console.WriteLine("SIm");
            }










            Console.Read();
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
                || bloco[7] == bloco[8])
                return 1;

            return 0;
        }

        private void criarBlocos()
        {
            bloco1 = new int[9];
            bloco2 = new int[9];
            bloco3 = new int[9];
            bloco4 = new int[9];
            bloco5 = new int[9];
            bloco6 = new int[9];
            bloco7 = new int[9];
            bloco8 = new int[9];
            bloco9 = new int[9];
            int aux = 0;

            aux = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int f = 0; f < 3; f++)
                {
                    bloco1[aux] = matrixSudoku[i, f];
                    aux++;
                }
            }
            aux = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int f = 0; f < 3; f++)
                {
                    bloco2[aux] = matrixSudoku[i + 3, f];
                    aux++;
                }
            }
            aux = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int f = 0; f < 3; f++)
                {
                    bloco3[aux] = matrixSudoku[i + 6, f];
                    aux++;
                }
            }
            aux = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int f = 0; f < 3; f++)
                {
                    bloco4[aux] = matrixSudoku[i, f + 3];
                    aux++;
                }
            }
            aux = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int f = 0; f < 3; f++)
                {
                    bloco5[aux] = matrixSudoku[i, f + 6];
                    aux++;
                }
            }
            aux = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int f = 0; f < 3; f++)
                {
                    bloco6[aux] = matrixSudoku[i + 3, f + 3];
                    aux++;
                }
            }
            aux = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int f = 0; f < 3; f++)
                {
                    bloco7[aux] = matrixSudoku[i + 3, f + 6];
                    aux++;
                }
            }
            aux = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int f = 0; f < 3; f++)
                {
                    bloco8[aux] = matrixSudoku[i + 6, f + 3];
                    aux++;
                }
            }
            aux = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int f = 0; f < 3; f++)
                {
                    bloco9[aux] = matrixSudoku[i + 6, f + 6];
                    aux++;
                }
            }
        }
        public int[,] criarMatriz()
        {
            int[,] matri = new int[9, 9];
            for (int d = 0; d < 9; d++)
            {
                matri[d, 0] = linha1[d];
                matri[d, 1] = linha2[d];
                matri[d, 2] = linha3[d];
                matri[d, 3] = linha4[d];
                matri[d, 4] = linha5[d];
                matri[d, 5] = linha6[d];
                matri[d, 6] = linha7[d];
                matri[d, 7] = linha8[d];
                matri[d, 8] = linha9[d];
            }
            return matri;
        }

        private void ValidarColunas()
        {
            for (int i = 0; i < linha1.Length; i++)
            {
                int[] blocoAux = new int[9];
                blocoAux[0] = linha1[i];
                blocoAux[1] = linha2[i];
                blocoAux[2] = linha3[i];
                blocoAux[3] = linha4[i];
                blocoAux[4] = linha5[i];
                blocoAux[5] = linha6[i];
                blocoAux[6] = linha7[i];
                blocoAux[7] = linha8[i];
                blocoAux[8] = linha9[i];
                simNao += validar(blocoAux);
            }
        }
        private string PegarLinhaUser()
        {
            return Console.ReadLine();
        }
        public int[] PegarArrayUsuario(string valorDefinido)
        {
            string[] linhaString = valorDefinido.Split();
            int[] linhaInt = new int[linhaString.Length];
            for (int i = 0; i < linhaString.Length; i++)
            {
                linhaInt[i] = Convert.ToInt32(linhaString[i]);
            }
            return linhaInt;
        }
        static void Main(string[] args)
        {
            new Program();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Autores do codigo : Matheus Conseição dos Santos, Maria Eduarda Costa Silva, Miguel Dantas, Gustavo, Gabriel Nogueira e Isabela Souza dos Santos.

            Console.Title = "Análise de Dados Climáticos";
            double[,] dadosB = new double[4, 31];

            //Dados retirados do INMET SP-São Paulo Aeroporto Congonhas

            // January 1, 2025
            dadosB[0, 0] = 6.0;   // Precipitation (mm)
            dadosB[1, 0] = 29.4;  // Max Temp (°C)
            dadosB[2, 0] = 19.5;  // Min Temp (°C)
            dadosB[3, 0] = 79.0;  // Average Humidity (%)

            // January 2, 2025
            dadosB[0, 1] = 0.0;
            dadosB[1, 1] = 31.1;
            dadosB[2, 1] = 20.2;
            dadosB[3, 1] = 67.7;

            // January 3, 2025
            dadosB[0, 2] = 6.0;
            dadosB[1, 2] = 30.4;
            dadosB[2, 2] = 21.0;
            dadosB[3, 2] = 69.7;

            // January 4, 2025
            dadosB[0, 3] = 0.0;
            dadosB[1, 3] = 28.8;
            dadosB[2, 3] = 21.3;
            dadosB[3, 3] = 67.0;

            // January 5, 2025
            dadosB[0, 4] = 0.0;
            dadosB[1, 4] = 27.1;
            dadosB[2, 4] = 19.9;
            dadosB[3, 4] = 75.7;

            // January 6, 2025
            dadosB[0, 5] = 0.0;
            dadosB[1, 5] = 28.6;
            dadosB[2, 5] = 19.5;
            dadosB[3, 5] = 82.0;

            // January 7, 2025
            dadosB[0, 6] = 0.0;
            dadosB[1, 6] = 27.2;
            dadosB[2, 6] = 21.0;
            dadosB[3, 6] = 83.3;

            // January 8, 2025
            dadosB[0, 7] = 4.0;
            dadosB[1, 7] = 25.9;
            dadosB[2, 7] = 19.5;
            dadosB[3, 7] = 83.7;

            // January 9, 2025
            dadosB[0, 8] = 0.0;
            dadosB[1, 8] = 23.3;
            dadosB[2, 8] = 19.1;
            dadosB[3, 8] = 80.7;

            // January 10, 2025
            dadosB[0, 9] = 0.0;
            dadosB[1, 9] = 24.6;
            dadosB[2, 9] = 17.7;
            dadosB[3, 9] = 73.7;

            // January 11, 2025
            dadosB[0, 10] = 0.0;
            dadosB[1, 10] = 26.9;
            dadosB[2, 10] = 16.2;
            dadosB[3, 10] = 71.0;

            // January 12, 2025
            dadosB[0, 11] = 0.0;
            dadosB[1, 11] = 23.7;
            dadosB[2, 11] = 18.5;
            dadosB[3, 11] = 78.0;

            // January 13, 2025
            dadosB[0, 12] = 0.0;
            dadosB[1, 12] = 23.8;
            dadosB[2, 12] = 16.6;
            dadosB[3, 12] = 68.0;

            // January 14, 2025
            dadosB[0, 13] = 0.0;
            dadosB[1, 13] = 22.6;
            dadosB[2, 13] = 16.5;
            dadosB[3, 13] = 75.3;

            // January 15, 2025
            dadosB[0, 14] = 0.0;
            dadosB[1, 14] = 27.4;
            dadosB[2, 14] = 18.7;
            dadosB[3, 14] = 72.3;

            // January 16, 2025
            dadosB[0, 15] = 0.0;
            dadosB[1, 15] = 28.5;
            dadosB[2, 15] = 20.4;
            dadosB[3, 15] = 84.0;

            // January 17, 2025
            dadosB[0, 16] = 44.0;
            dadosB[1, 16] = 27.4;
            dadosB[2, 16] = 21.2;
            dadosB[3, 16] = 78.7;

            // January 18, 2025
            dadosB[0, 17] = 0.0;
            dadosB[1, 17] = 31.6;
            dadosB[2, 17] = 21.6;
            dadosB[3, 17] = 66.7;

            // January 19, 2025
            dadosB[0, 18] = 0.0;
            dadosB[1, 18] = 31.7;
            dadosB[2, 18] = 23.5;
            dadosB[3, 18] = 62.7;

            // January 20, 2025
            dadosB[0, 19] = 0.0;
            dadosB[1, 19] = 31.1;
            dadosB[2, 19] = 22.5;
            dadosB[3, 19] = 70.5;

            // January 21, 2025
            dadosB[0, 20] = 0.0;
            dadosB[1, 20] = 32.2;
            dadosB[2, 20] = 23.9;
            dadosB[3, 20] = 54.0;

            // January 22, 2025
            dadosB[0, 21] = 0.0;
            dadosB[1, 21] = 32.1;
            dadosB[2, 21] = 24.0;
            dadosB[3, 21] = 58.7;

            // January 23, 2025
            dadosB[0, 22] = 0.0;
            dadosB[1, 22] = 29.7;
            dadosB[2, 22] = 22.0;
            dadosB[3, 22] = 73.0;

            // January 24, 2025
            dadosB[0, 23] = 0.0;
            dadosB[1, 23] = 29.4;
            dadosB[2, 23] = 21.5;
            dadosB[3, 23] = 71.0;

            // January 25, 2025
            dadosB[0, 24] = 6.0;
            dadosB[1, 24] = 32.5;
            dadosB[2, 24] = 21.2;
            dadosB[3, 24] = 70.0;

            // January 26, 2025
            dadosB[0, 25] = 0.0;
            dadosB[1, 25] = 29.8;
            dadosB[2, 25] = 21.9;
            dadosB[3, 25] = 77.0;

            // January 27, 2025
            dadosB[0, 26] = 19.0;
            dadosB[1, 26] = 25.4;
            dadosB[2, 26] = 20.6;
            dadosB[3, 26] = 84.0;

            // January 28, 2025
            dadosB[0, 27] = 0.6;
            dadosB[1, 27] = 27.9;
            dadosB[2, 27] = 19.7;
            dadosB[3, 27] = 85.7;

            // January 29, 2025
            dadosB[0, 28] = 0.0;
            dadosB[1, 28] = 25.1;
            dadosB[2, 28] = 21.4;
            dadosB[3, 28] = 87.3;

            // January 30, 2025
            dadosB[0, 29] = 27.0;
            dadosB[1, 29] = 25.9;
            dadosB[2, 29] = 20.7;
            dadosB[3, 29] = 93.0;

            // January 31, 2025
            dadosB[0, 30] = 14.0;
            dadosB[1, 30] = 27.0;
            dadosB[2, 30] = 21.0;
            dadosB[3, 30] = 83.7;
            byte esc = 0;
            // Borda e cor
            void voltar()
            {
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                Console.Clear();
                Console.SetCursorPosition(30, 8);
                Console.WriteLine("\u250C\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2510");
                Console.SetCursorPosition(30, 9);
                Console.WriteLine('\u2502');
                Console.SetCursorPosition(30, 10);
                Console.WriteLine("\u251C\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2524");
                Console.SetCursorPosition(30, 11);
                Console.WriteLine('\u2502');
                Console.SetCursorPosition(30, 12);
                Console.WriteLine('\u2502');
                Console.SetCursorPosition(30, 13);
                Console.WriteLine('\u2502');
                Console.SetCursorPosition(30, 14);
                Console.WriteLine('\u2502');
                Console.SetCursorPosition(30, 15);
                Console.WriteLine('\u2502');
                Console.SetCursorPosition(30, 16);
                Console.WriteLine('\u2502');
                Console.SetCursorPosition(30, 17);
                Console.WriteLine('\u2502');
                Console.SetCursorPosition(30, 18);
                Console.WriteLine("\u251C\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2524");
                Console.SetCursorPosition(30, 19);
                Console.WriteLine('\u2502');
                Console.SetCursorPosition(30, 20);
                Console.WriteLine("\u2514\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2518");
                Console.SetCursorPosition(79, 9);
                Console.WriteLine('\u2502');
                Console.SetCursorPosition(79, 11);
                Console.WriteLine('\u2502');
                Console.SetCursorPosition(79, 12);
                Console.WriteLine('\u2502');
                Console.SetCursorPosition(79, 13);
                Console.WriteLine('\u2502');
                Console.SetCursorPosition(79, 14);
                Console.WriteLine('\u2502');
                Console.SetCursorPosition(79, 15);
                Console.WriteLine('\u2502');
                Console.SetCursorPosition(79, 16);
                Console.WriteLine('\u2502');
                Console.SetCursorPosition(79, 17);
                Console.WriteLine('\u2502');
                Console.SetCursorPosition(79, 19);
                Console.WriteLine('\u2502');




                Console.SetCursorPosition(42, 9);
                Console.WriteLine("=== Análise de Dados Climáticos ===");
                Console.SetCursorPosition(31, 12);
                Console.WriteLine("1. Médias do Mês");
                Console.SetCursorPosition(31, 13);
                Console.WriteLine("2. Valores Extremos");
                Console.SetCursorPosition(31, 14);
                Console.WriteLine("3. Distribuições");
                Console.SetCursorPosition(31, 15);
                Console.WriteLine("4. Análises Avançadas");
                Console.SetCursorPosition(31, 16);
                Console.WriteLine("5. Ordenação e Pesquisa");
                Console.SetCursorPosition(31, 17);
                Console.WriteLine("6. Comparações Semanais");
                Console.SetCursorPosition(31, 18);
                Console.WriteLine("7. sair");
                Console.SetCursorPosition(31, 19);
                Console.Write("Escolha uma opção: ");
                esc = byte.Parse(Console.ReadLine());


                if (esc == 1)
                {
                    medias();
                }



                //consulta
                else if (esc == 2)
                {

                    ValEx();


                }
                //lista
                else if (esc == 3)
                {

                    Distribui();


                }
                else if (esc == 4)
                {

                    Anali();


                }
                else if (esc == 5)
                {

                    Ordenacao();


                }
                else if (esc == 6)
                {

                    Compara();


                }
                // função sair
                else if (esc == 7)
                {

                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Clear();
                    Console.Out.Close();
                }
                else
                {
                    Console.SetCursorPosition(31, 19);
                    Console.Write("Erro! Pressione qualquer tecla para voltar...");
                    Console.ReadKey();
                    voltar();

                }

            }
            voltar();


            void medias()
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Clear();
                Console.SetCursorPosition(30, 8);
                Console.WriteLine("\u250C\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2510");
                Console.SetCursorPosition(30, 9);
                Console.WriteLine('\u2502');
                Console.SetCursorPosition(30, 10);
                Console.WriteLine("\u251C\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2524");
                Console.SetCursorPosition(30, 11);
                Console.WriteLine('\u2502');
                Console.SetCursorPosition(30, 12);
                Console.WriteLine('\u2502');
                Console.SetCursorPosition(30, 13);
                Console.WriteLine('\u2502');
                Console.SetCursorPosition(30, 14);
                Console.WriteLine('\u2502');
                Console.SetCursorPosition(30, 15);
                Console.WriteLine('\u2502');
                Console.SetCursorPosition(30, 16);
                Console.WriteLine('\u2502');
                Console.SetCursorPosition(30, 17);
                Console.WriteLine('\u2502');
                Console.SetCursorPosition(30, 18);
                Console.WriteLine("\u251C\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2524");
                Console.SetCursorPosition(30, 19);
                Console.WriteLine('\u2502');
                Console.SetCursorPosition(30, 20);
                Console.WriteLine('\u2502');
                Console.SetCursorPosition(30, 21);
                Console.WriteLine("\u2514\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2518");
                Console.SetCursorPosition(100, 9);
                Console.WriteLine('\u2502');
                Console.SetCursorPosition(100, 11);
                Console.WriteLine('\u2502');
                Console.SetCursorPosition(100, 12);
                Console.WriteLine('\u2502');
                Console.SetCursorPosition(100, 13);
                Console.WriteLine('\u2502');
                Console.SetCursorPosition(100, 14);
                Console.WriteLine('\u2502');
                Console.SetCursorPosition(100, 15);
                Console.WriteLine('\u2502');
                Console.SetCursorPosition(100, 16);
                Console.WriteLine('\u2502');
                Console.SetCursorPosition(100, 17);
                Console.WriteLine('\u2502');
                Console.SetCursorPosition(100, 19);
                Console.WriteLine('\u2502');
                Console.SetCursorPosition(100, 20);
                Console.WriteLine('\u2502');


                Console.SetCursorPosition(50, 9);
                Console.WriteLine("=== Cadastrar Produto ===");

                Console.WriteLine("Aperte qualquer tecla para voltar");


                Console.ReadKey();
                voltar();
            }














            //consulta
            void ValEx()
            {
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Clear();
                Console.SetCursorPosition(30, 8);
                Console.WriteLine("\u250C\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2510");
                Console.SetCursorPosition(30, 9);
                Console.WriteLine('\u2502');
                Console.SetCursorPosition(30, 10);
                Console.WriteLine("\u251C\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2524");
                Console.SetCursorPosition(30, 11);
                Console.WriteLine('\u2502');
                Console.SetCursorPosition(30, 12);
                Console.WriteLine('\u2502');
                Console.SetCursorPosition(30, 13);
                Console.WriteLine('\u2502');
                Console.SetCursorPosition(30, 14);
                Console.WriteLine('\u2502');
                Console.SetCursorPosition(30, 15);
                Console.WriteLine('\u2502');
                Console.SetCursorPosition(30, 16);
                Console.WriteLine('\u2502');
                Console.SetCursorPosition(30, 17);
                Console.WriteLine('\u2502');
                Console.SetCursorPosition(30, 18);
                Console.WriteLine("\u251C\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2524");
                Console.SetCursorPosition(30, 19);
                Console.WriteLine('\u2502');
                Console.SetCursorPosition(30, 20);
                Console.WriteLine('\u2502');
                Console.SetCursorPosition(30, 21);
                Console.WriteLine("\u2514\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2518");
                Console.SetCursorPosition(100, 9);
                Console.WriteLine('\u2502');
                Console.SetCursorPosition(100, 11);
                Console.WriteLine('\u2502');
                Console.SetCursorPosition(100, 12);
                Console.WriteLine('\u2502');
                Console.SetCursorPosition(100, 13);
                Console.WriteLine('\u2502');
                Console.SetCursorPosition(100, 14);
                Console.WriteLine('\u2502');
                Console.SetCursorPosition(100, 15);
                Console.WriteLine('\u2502');
                Console.SetCursorPosition(100, 16);
                Console.WriteLine('\u2502');
                Console.SetCursorPosition(100, 17);
                Console.WriteLine('\u2502');
                Console.SetCursorPosition(100, 19);
                Console.WriteLine('\u2502');
                Console.SetCursorPosition(100, 20);
                Console.WriteLine('\u2502');

                Console.SetCursorPosition(50, 9);
                Console.Write("=== Consulta de produto ===");




                Console.ReadKey();
                voltar();





            }
            //lista
            void Distribui()
            {
                Console.BackgroundColor = ConsoleColor.DarkMagenta;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Clear();
                Console.SetCursorPosition(30, 8);
                Console.WriteLine("\u250C\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2510");
                Console.SetCursorPosition(30, 9);
                Console.WriteLine('\u2502');
                Console.SetCursorPosition(30, 10);
                Console.WriteLine("\u251C\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2524");
                Console.SetCursorPosition(30, 11);
                Console.WriteLine('\u2502');
                Console.SetCursorPosition(30, 12);
                Console.WriteLine('\u2502');
                Console.SetCursorPosition(30, 13);
                Console.WriteLine('\u2502');
                Console.SetCursorPosition(30, 14);
                Console.WriteLine('\u2502');
                Console.SetCursorPosition(30, 15);
                Console.WriteLine('\u2502');
                Console.SetCursorPosition(30, 16);
                Console.WriteLine('\u2502');
                Console.SetCursorPosition(30, 17);
                Console.WriteLine('\u2502');
                Console.SetCursorPosition(30, 18);
                Console.WriteLine("\u251C\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2524");
                Console.SetCursorPosition(30, 19);
                Console.WriteLine('\u2502');
                Console.SetCursorPosition(30, 20);
                Console.WriteLine('\u2502');
                Console.SetCursorPosition(30, 21);
                Console.WriteLine("\u2514\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2518");
                Console.SetCursorPosition(100, 9);
                Console.WriteLine('\u2502');
                Console.SetCursorPosition(100, 11);
                Console.WriteLine('\u2502');
                Console.SetCursorPosition(100, 12);
                Console.WriteLine('\u2502');
                Console.SetCursorPosition(100, 13);
                Console.WriteLine('\u2502');
                Console.SetCursorPosition(100, 14);
                Console.WriteLine('\u2502');
                Console.SetCursorPosition(100, 15);
                Console.WriteLine('\u2502');
                Console.SetCursorPosition(100, 16);
                Console.WriteLine('\u2502');
                Console.SetCursorPosition(100, 17);
                Console.WriteLine('\u2502');
                Console.SetCursorPosition(100, 19);
                Console.WriteLine('\u2502');
                Console.SetCursorPosition(100, 20);
                Console.WriteLine('\u2502');
                Console.SetCursorPosition(50, 9);
                Console.WriteLine("=== Lista Produtos ===");
                Console.SetCursorPosition(35, 11);
                Console.WriteLine("Código");
                Console.SetCursorPosition(45, 11);
                Console.WriteLine("Nome");
                Console.SetCursorPosition(58, 11);
                Console.WriteLine("Categoria");
                Console.SetCursorPosition(71, 11);
                Console.WriteLine("Preço");
                Console.SetCursorPosition(80, 11);
                Console.WriteLine("% Lucro");
                Console.SetCursorPosition(91, 11);
                Console.WriteLine("Estoque");


                Console.ReadKey();
                voltar();



            }

            void Anali()
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Clear();
                Console.SetCursorPosition(30, 8);
                Console.WriteLine("\u250C\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2510");
                Console.SetCursorPosition(30, 9);
                Console.WriteLine('\u2502');
                Console.SetCursorPosition(30, 10);
                Console.WriteLine("\u251C\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2524");
                Console.SetCursorPosition(30, 11);
                Console.WriteLine('\u2502');
                Console.SetCursorPosition(30, 12);
                Console.WriteLine('\u2502');
                Console.SetCursorPosition(30, 13);
                Console.WriteLine('\u2502');
                Console.SetCursorPosition(30, 14);
                Console.WriteLine('\u2502');
                Console.SetCursorPosition(30, 15);
                Console.WriteLine('\u2502');
                Console.SetCursorPosition(30, 16);
                Console.WriteLine('\u2502');
                Console.SetCursorPosition(30, 17);
                Console.WriteLine('\u2502');
                Console.SetCursorPosition(30, 18);
                Console.WriteLine("\u251C\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2524");
                Console.SetCursorPosition(30, 19);
                Console.WriteLine('\u2502');
                Console.SetCursorPosition(30, 20);
                Console.WriteLine('\u2502');
                Console.SetCursorPosition(30, 21);
                Console.WriteLine("\u2514\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2518");
                Console.SetCursorPosition(100, 9);
                Console.WriteLine('\u2502');
                Console.SetCursorPosition(100, 11);
                Console.WriteLine('\u2502');
                Console.SetCursorPosition(100, 12);
                Console.WriteLine('\u2502');
                Console.SetCursorPosition(100, 13);
                Console.WriteLine('\u2502');
                Console.SetCursorPosition(100, 14);
                Console.WriteLine('\u2502');
                Console.SetCursorPosition(100, 15);
                Console.WriteLine('\u2502');
                Console.SetCursorPosition(100, 16);
                Console.WriteLine('\u2502');
                Console.SetCursorPosition(100, 17);
                Console.WriteLine('\u2502');
                Console.SetCursorPosition(100, 19);
                Console.WriteLine('\u2502');
                Console.SetCursorPosition(100, 20);
                Console.WriteLine('\u2502');


                Console.SetCursorPosition(50, 9);
                Console.WriteLine("=== Cadastrar Produto ===");

                Console.WriteLine("Aperte qualquer tecla para voltar");


                Console.ReadKey();
                voltar();
            }
            void Ordenacao()
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Clear();
                Console.SetCursorPosition(30, 8);
                Console.WriteLine("\u250C\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2510");
                Console.SetCursorPosition(30, 9);
                Console.WriteLine('\u2502');
                Console.SetCursorPosition(30, 10);
                Console.WriteLine("\u251C\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2524");
                Console.SetCursorPosition(30, 11);
                Console.WriteLine('\u2502');
                Console.SetCursorPosition(30, 12);
                Console.WriteLine('\u2502');
                Console.SetCursorPosition(30, 13);
                Console.WriteLine('\u2502');
                Console.SetCursorPosition(30, 14);
                Console.WriteLine('\u2502');
                Console.SetCursorPosition(30, 15);
                Console.WriteLine('\u2502');
                Console.SetCursorPosition(30, 16);
                Console.WriteLine('\u2502');
                Console.SetCursorPosition(30, 17);
                Console.WriteLine('\u2502');
                Console.SetCursorPosition(30, 18);
                Console.WriteLine("\u251C\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2524");
                Console.SetCursorPosition(30, 19);
                Console.WriteLine('\u2502');
                Console.SetCursorPosition(30, 20);
                Console.WriteLine('\u2502');
                Console.SetCursorPosition(30, 21);
                Console.WriteLine("\u2514\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2518");
                Console.SetCursorPosition(100, 9);
                Console.WriteLine('\u2502');
                Console.SetCursorPosition(100, 11);
                Console.WriteLine('\u2502');
                Console.SetCursorPosition(100, 12);
                Console.WriteLine('\u2502');
                Console.SetCursorPosition(100, 13);
                Console.WriteLine('\u2502');
                Console.SetCursorPosition(100, 14);
                Console.WriteLine('\u2502');
                Console.SetCursorPosition(100, 15);
                Console.WriteLine('\u2502');
                Console.SetCursorPosition(100, 16);
                Console.WriteLine('\u2502');
                Console.SetCursorPosition(100, 17);
                Console.WriteLine('\u2502');
                Console.SetCursorPosition(100, 19);
                Console.WriteLine('\u2502');
                Console.SetCursorPosition(100, 20);
                Console.WriteLine('\u2502');


                Console.SetCursorPosition(50, 9);
                Console.WriteLine("=== Cadastrar Produto ===");

                Console.WriteLine("Aperte qualquer tecla para voltar");


                Console.ReadKey();
                voltar();
            }

            void Compara()
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Clear();
                Console.SetCursorPosition(30, 8);
                Console.WriteLine("\u250C\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2510");
                Console.SetCursorPosition(30, 9);
                Console.WriteLine('\u2502');
                Console.SetCursorPosition(30, 10);
                Console.WriteLine("\u251C\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2524");
                Console.SetCursorPosition(30, 11);
                Console.WriteLine('\u2502');
                Console.SetCursorPosition(30, 12);
                Console.WriteLine('\u2502');
                Console.SetCursorPosition(30, 13);
                Console.WriteLine('\u2502');
                Console.SetCursorPosition(30, 14);
                Console.WriteLine('\u2502');
                Console.SetCursorPosition(30, 15);
                Console.WriteLine('\u2502');
                Console.SetCursorPosition(30, 16);
                Console.WriteLine('\u2502');
                Console.SetCursorPosition(30, 17);
                Console.WriteLine('\u2502');
                Console.SetCursorPosition(30, 18);
                Console.WriteLine("\u251C\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2524");
                Console.SetCursorPosition(30, 19);
                Console.WriteLine('\u2502');
                Console.SetCursorPosition(30, 20);
                Console.WriteLine('\u2502');
                Console.SetCursorPosition(30, 21);
                Console.WriteLine("\u2514\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2518");
                Console.SetCursorPosition(100, 9);
                Console.WriteLine('\u2502');
                Console.SetCursorPosition(100, 11);
                Console.WriteLine('\u2502');
                Console.SetCursorPosition(100, 12);
                Console.WriteLine('\u2502');
                Console.SetCursorPosition(100, 13);
                Console.WriteLine('\u2502');
                Console.SetCursorPosition(100, 14);
                Console.WriteLine('\u2502');
                Console.SetCursorPosition(100, 15);
                Console.WriteLine('\u2502');
                Console.SetCursorPosition(100, 16);
                Console.WriteLine('\u2502');
                Console.SetCursorPosition(100, 17);
                Console.WriteLine('\u2502');
                Console.SetCursorPosition(100, 19);
                Console.WriteLine('\u2502');
                Console.SetCursorPosition(100, 20);
                Console.WriteLine('\u2502');


                Console.SetCursorPosition(50, 9);
                Console.WriteLine("=== Cadastrar Produto ===");

                Console.WriteLine("Aperte qualquer tecla para voltar");


                Console.ReadKey();
                voltar();
            }

           






        }

    }
}




    


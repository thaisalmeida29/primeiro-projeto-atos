using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace desafio_atos
{
    internal class Persistencia
    {
        /// <summary>
        /// grava a lista no arquivo de entrada
        /// </summary>
        /// <param name="lista"></param>
        public static void gravarNoArquivoEntrada(List<Veiculo> lista)
        {
            StreamWriter escritor = new StreamWriter("veiculosEntrada.dat");

            foreach (Veiculo i in lista)
            {
                escritor.WriteLine(i.Placa + ";" + i.DataEntrada + ";" + i.HoraEntrada);
                escritor.Flush();
            }
            escritor.Close();

        }
        /// <summary>
        /// grava a lista no arquivo de saida
        /// </summary>
        /// <param name="lista"></param>

        public static void gravarNoArquivoSaida(List<Veiculo> lista)
        {
            StreamWriter escritor = new StreamWriter("veiculosSaida.dat");

            foreach (Veiculo i in lista)
            {
                escritor.WriteLine(i.Placa + ";" + i.DataEntrada + ";" + i.HoraEntrada + ";" + i.DataSaida + ";" + i.HoraSaida + ";" + i.TempoPermanencia + ";" + i.ValorCobrado);
                escritor.Flush();
            }
            escritor.Close();
        }
        /// <summary>
        /// ler o arquivo de entrada
        /// </summary>
        /// <param name="lista"></param>
        public static void lerArquivoEntrada(List<Veiculo> lista)
        {
            if (File.Exists("veiculosEntrada.dat"))
            {
                StreamReader leitor = new StreamReader("veiculosEntrada.dat");
                string linha;
                string[] vetorDados;

                do
                {
                    linha = leitor.ReadLine();
                    if (!string.IsNullOrEmpty(linha))
                    {
                        vetorDados = linha.Split(';');
                        lista.Add(new Veiculo(vetorDados[0], vetorDados[1], vetorDados[2]));
                    }
                } while (!leitor.EndOfStream);
                leitor.Close();
            }
        }
        /// <summary>
        /// ler arquivo de saida
        /// </summary>
        /// <param name="lista"></param>
        public static void lerArquivoSaida(List<Veiculo> lista)
        {
            if (File.Exists("veiculosSaida.dat"))
            {
                StreamReader leitor = new StreamReader("veiculosSaida.dat");
                string linha;
                string[] vetorDados;

                do
                {
                    linha = leitor.ReadLine();
                    if (!string.IsNullOrEmpty(linha))
                    {
                        vetorDados = linha.Split(';');
                        lista.Add(new Veiculo(vetorDados[0], vetorDados[1], vetorDados[2],
                            vetorDados[3], vetorDados[4], int.Parse(vetorDados[5]), double.Parse(vetorDados[6])));
                    }
                } while (!leitor.EndOfStream);
                leitor.Close();
            }
        }
    }
}


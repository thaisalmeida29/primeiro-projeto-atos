﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafio_atos
{
    internal class Veiculo
    {
        string placa; // 7 caracteres
        string dataEntrada;
        string horaEntrada;
        string dataSaida;
        string horaSaida;
        int tempoPermanencia; //minutos
        double valorCobrado;

        /// <summary>
        /// construtor é utilizado na leitura do arquivo para popular a lista
        /// </summary>
        /// <param name="placa">identificação do veiculo</param>
       
  
        public Veiculo(string placa, string dataEntrada, string horaEntrada)
        {
            this.Placa = placa;
            this.dataEntrada = dataEntrada;
            this.HoraEntrada = horaEntrada;
        }

        public Veiculo(string placa, string dataEntrada, string horaEntrada, string dataSaida, string horaSaida, int tempoPermanencia, double valorCobrado) : this(placa, dataEntrada, horaEntrada)
        {
            this.dataSaida = dataSaida;
            this.horaSaida = horaSaida;
            this.tempoPermanencia = tempoPermanencia;
            this.valorCobrado = valorCobrado;
        }



        /// <summary>
        /// metodo que gera a data e hora para entrada
        /// ou saida de veiculo
        /// </summary>
        /// <param name="tipo">entrada para gerar data e hora de entrada e de saida</param>
        public void gerarDataHora(string tipo)
        {
            DateTime dateTime = DateTime.Now;
            string[] vetorDados = dateTime.ToString().Split(' ');  
            switch (tipo)
            {
                case "entrada":
                  this.DataEntrada = vetorDados[0];
                   this.HoraEntrada = vetorDados[1];
                    break;
                case "saida":
                   this.DataSaida = vetorDados[0];
                   this.HoraSaida = vetorDados[1];
                    break;
                default:
                    break;
            }
        }

        public void realizarCobranca(double valorHora)
        {
            // descobrindo tempo de entrada
            string[] vetorDados = horaEntrada.Split(':'); 
            int hora = int.Parse(vetorDados[0]);
            int minutos = int.Parse(vetorDados[1]);
            int entrada = hora * 60 + minutos;


            // descobrindo tempo de saida
            vetorDados = horaSaida.Split(':');
            hora = int.Parse(vetorDados[0]);
            minutos = int.Parse(vetorDados[1]);
            int saida = hora * 60 + minutos;

            this.TempoPermanencia = saida - entrada;
            var timeSpanFromMinutes = TimeSpan.FromMinutes(this.TempoPermanencia);
            int tempoPermanenciaEmHoras = timeSpanFromMinutes.Hours;
            if(tempoPermanenciaEmHoras == 0)
            {
                tempoPermanenciaEmHoras = 1;
            }

            this.ValorCobrado = tempoPermanenciaEmHoras * valorHora;
        }

        public string Placa { get => placa; set => placa = value; }
        public string DataEntrada { get => dataEntrada; set => dataEntrada = value; }
        public string HoraEntrada { get => horaEntrada; set => horaEntrada = value; }
        public string DataSaida { get => dataSaida; set => dataSaida = value; }
        public string HoraSaida { get => horaSaida; set => horaSaida = value; }
        public int TempoPermanencia { get => tempoPermanencia; set => tempoPermanencia = value; }
        public double ValorCobrado { get => valorCobrado; set => valorCobrado = value; }


        public static int localizado(string placa, List<Veiculo> lista)
        {
            foreach(Veiculo i in lista)
            {
                if (i.Placa.Equals(placa))
                {
                    return lista.IndexOf(i);
                }
            }
            return -27; //codigo do esc, ou seja, veiculo não localizado
        }

        public static bool temLugar(List<Veiculo> lista, int tamanhoGaragem)
        {
            return lista.Count < tamanhoGaragem;
        }

        
    }
}
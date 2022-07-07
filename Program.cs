using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cidade = "", mesEscrito = "";
            double a, dia, mes, ano;
            Console.WriteLine("Escolha uma cidade e digite o código: \n1- Atibaia \n2- Bragança Paulista \n3 - Mairiporã \n4 - Nazaré \n5 - Terra preta \n6 - Extrema \n7 - Vargem");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite uma data (dd/mm/aaaa): ");
            var Data = Convert.ToDateTime(Console.ReadLine());
            dia = Data.Day;
            mes = Data.Month;
            ano = Data.Year;

            switch (mes)
            {
                case 1:
                    mesEscrito = "Janeiro";
                    break;
                case 2:
                    mesEscrito = "Fevereiro";
                    break;
                case 3:
                    mesEscrito = "Março";
                    break;
                case 4:
                    mesEscrito = "Abril";
                    break;
                case 5:
                    mesEscrito = "Maio";
                    break;
                case 6:
                    mesEscrito = "Junho";
                    break;
                case 7:
                    mesEscrito = "Julho";
                    break;
                case 8:
                    mesEscrito = "Agosto";
                    break;
                case 9:
                    mesEscrito = "Setembro";
                    break;
                case 10:
                    mesEscrito = "Outubro";
                    break;
                case 11:
                    mesEscrito = "Novembro";
                    break;
                case 12:
                    mesEscrito = "Dezembro";
                    break;
            }

            switch (a)
            {
                case 1:
                    cidade = "Atibaia";
                    break;
                case 2:
                    cidade = "Bragança Paulista";
                    break;
                case 3:
                    cidade = "Mairiporã";
                    break;
                case 4:
                    cidade = "Nazaré";
                    break;
                case 5:
                    cidade = "Terra Preta";
                    break;
                case 6:
                    cidade = "Extrema";
                    break;
                case 7:
                    cidade = "Vargem";
                    break;
            }

            Console.WriteLine(cidade + ", " + dia + " de " + mesEscrito + " de " + ano);

            Console.ReadKey();
        }
    }
}

using System;

namespace Trabalho2
{
    class Program
    {
        static void Main(string[] args)
        {

            int op = 0;

            Console.WriteLine("\n\nT01 - Circuitos elétricos\n");
            float R1 = 0, R2 = 0, F = 0;
            Circuito circuito1 = new Circuito(R1, R2, F);
            Circuito circuito2 = new Circuito(R1, R2, F);

            while (op <= 1) {
                Console.WriteLine("\nCircuito "+ (op + 1) +"\n");
                Console.WriteLine("Informe o valor da resistencia R1 ");
                R1 = float.Parse(Console.ReadLine());
                Console.WriteLine("Informe o valor da resistencia R2 ");
                R2 = float.Parse(Console.ReadLine());
                Console.WriteLine("Informe o valor da Fonte de tensão");
                F = float.Parse(Console.ReadLine());

                if ((R1 > 0) && (R2 > 0)) {
                    if (op == 0) {
                        circuito1.setR1(R1);
                        circuito1.setR2(R2);
                        circuito1.setF1(F);

                    } else {
                        circuito2.setR1(R1);
                        circuito2.setR2(R2);
                        circuito2.setF1(F);
                    }

                    op++;
                } else {
                    Console.WriteLine("Informe resistencias maiores que zero\n");
                }
            }

            Console.WriteLine( "\nCircuito 1\n");
            Console.WriteLine( "Valor total da resistencia em serie: "
                + circuito1.resistenciaSerie() + "\n");
            Console.WriteLine( "Valor total da corrente em serie: "
                + circuito1.correnteTotalSerie() + "\n");
            Console.WriteLine( "Valor total da Potencia com resistencias em Serie: "
                + circuito1.potenciaFonteSerie() + "\n");
            Console.WriteLine( "Valor total da resistencia em paralelo: "
                + circuito1.resistenciaParalelo() + "\n");
            Console.WriteLine( "Valor total da corrente em paralelo: "
                + circuito1.correnteTotalParalelo() + "\n");
            Console.WriteLine( "Valor total da Potencia com resistencias em Paralelo: "
                + circuito1.potenciaFonteParalelo() + "\n");

            Console.WriteLine( "\nCircuito 2\n");
            Console.WriteLine( "Valor total da resistencia em serie: "
                + circuito2.resistenciaSerie() + "\n");
            Console.WriteLine( "Valor total da corrente em serie: "
                + circuito2.correnteTotalSerie() + "\n");
            Console.WriteLine( "Valor total da Potencia com resistencias em Serie: "
                + circuito2.potenciaFonteSerie() + "\n");
            Console.WriteLine( "Valor total da resistencia em paralelo: "
                + circuito2.resistenciaParalelo() + "\n");
            Console.WriteLine( "Valor total da corrente em paralelo: "
                + circuito2.correnteTotalParalelo() + "\n");
            Console.WriteLine( "Valor total da Potencia com resistencias em Paralelo: "
                + circuito2.potenciaFonteParalelo() + "\n");

            Console.WriteLine( "\nComparação de potencias dos circuitos com resistencias em "
                    + "Serie");
            Circuito c1 = Circuito.potObjSerie(circuito1, circuito2);
            
            Console.WriteLine( "A menor potencia em Serie é " + c1.potenciaFonteSerie());

            Console.WriteLine( "\nComparação de potencias dos circuitos com resistencias em "
            +         "Paralelo");
            Circuito c2 = Circuito.potObjParalelo(circuito1, circuito2);
            Console.WriteLine( "A menor potencia em Paralelo é " + c2.potenciaFonteParalelo());
        }
    }
}

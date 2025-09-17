using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace practica_sem4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ejer5();
            Console.ReadKey();

        }
        static void ejer2()
        {
            Console.Write("Ingrese un año: ");
            int año = int.Parse(Console.ReadLine());

            if (año % 4 == 0)
                if (año % 100 == 0)
                    if (año % 400 == 0) ;
                    else
                        Console.WriteLine("No es Año bisiesto");
                else
                    Console.WriteLine("Es Año bisiesto");
            else
                Console.WriteLine("No es Año bisiesto");
            if (año % 2 == 0)
                Console.WriteLine("Es un Año Par");
            else
                Console.WriteLine("Es un Año Impar");
        }
        static void ejer3()
        {
            Console.Write("Ingrese el monto en Soles(PEN): ");
            double monto = double.Parse(Console.ReadLine());
            Console.WriteLine("\n¿A que quiere Convertir?: ");
            Console.WriteLine(" (1) USD ");
            Console.WriteLine(" (2) EUR ");
            Console.WriteLine(" Elige una opcion:");
            int opcion = int.Parse(Console.ReadLine());

            double USD = (monto / 3.75);
            double EUR = (monto / 4.05); 

            switch (opcion)
            {
                case 1:
                Console.WriteLine("En dolares son:  " + USD.ToString("0.00") );
                    break;
                case 2:
                    Console.WriteLine("En Euros son: " + EUR.ToString("0.00"));
                    break;
                default:
                    Console.WriteLine("Datos no encontrado");
                    break;

            }
            Console.ReadKey();


        }

        static void ejer4()
        {
            Console.WriteLine("Selecciona la Accion que quiere realizar");
            Console.WriteLine("------ Calculos de areas ------ ");
            Console.WriteLine("(1)Area del cuadrado:");
            Console.WriteLine("(2)Area del Rectangulo: ");
            Console.WriteLine("(3)Area del Triangulo: ");
            Console.WriteLine("(4)Area del Circulo: ");
            Console.Write("Elige una Opcion:  ");

            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.Write("Ingrese el lado del Cuadrado: ");
                    double lado = double.Parse(Console.ReadLine());
                    double areacua = lado * lado;
                    Console.WriteLine("El Area del Cuadrado es: " + areacua);
                    break;
                case 2:
                    Console.Write("Ingrese la base del rectangulo: ");
                    double barec = double.Parse(Console.ReadLine());
                    Console.Write("Ingrese la altura del rectangulo: ");
                    double alrect = double.Parse(Console.ReadLine());
                    double arearect = barec * alrect;
                    Console.WriteLine("El area del rectangulo es: " + arearect);
                    break;
                case 3:
                    Console.Write("Ingrese la base del triangulo: ");
                    double batria = double.Parse(Console.ReadLine());
                    Console.Write("Ingrese la altura del triangulo: ");
                    double altria = double.Parse(Console.ReadLine());
                    double areatria = (batria * altria) / 2;
                    Console.WriteLine("El area del triangulo es: " + areatria);
                    break;
                case 4:
                    Console.Write("Ingrese el radio del circulo: ");
                    double rad = double.Parse(Console.ReadLine());
                    double areacirc = Math.PI * Math.Pow(rad, 2);
                    Console.WriteLine("El Area del Circulo es: " + areacirc.ToString("0.00"));
                    break;
                default:
                    Console.WriteLine("Valor ingresado incorrecto.");
                    break;
             
            }
        }

        static void ejer5()
        {
            Console.Write("Ingrese su 1ra nota: ");
            int nota1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese su 2da nota: ");
            int nota2 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese su 3ra nota: ");
            int nota3 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese su 4ta nota: ");
            int nota4 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese su 5ta nota: ");
            int nota5 = int.Parse(Console.ReadLine());

            int notafinal = (nota1 + nota2 + nota3 + nota4 + nota5) / 5;
            
            Console.WriteLine("SU NOTA FINAL ES: " + notafinal);
        }
    }
 }

using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_sem5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¿En que Falcultad estudias?");
            Console.WriteLine("1. Medicina");
            Console.WriteLine("2. Ingenieria");
            Console.WriteLine("3. Negocios");
            Console.WriteLine("4. Educacion");
            Console.Write("Seleccione su Facultad de estudios [1-4]: ");
            int Facultad = int.Parse(Console.ReadLine());

            Console.Write("Cuantos Creditos llevas: ");
            int Creditos = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el promedio de Nota: ");
            int Nota = int.Parse(Console.ReadLine());
            if(Nota < 1 || Nota > 20)
            {
                Console.WriteLine("Nota no valida");
            }
            Console.WriteLine("Colegio de Procedencia[1-2]");
            Console.WriteLine("1. Colegio Nacional");
            Console.WriteLine("2. Colegio Privado");
            Console.Write("Seleccione una opcion de Colegio: ");
            int Colegio = int.Parse(Console.ReadLine());

            Console.WriteLine(" Como deseas pagar todo");
            Console.WriteLine("1. Completo");
            Console.WriteLine("2. Cuotas");
            Console.Write("Seleccione una opcion de pago : ");
            int pago = int.Parse(Console.ReadLine());

            double pagcicfi = 0;
            double pagcic = 0;
            double monpacre = 0;
            double monpano = 0;
            double monpaco = 0;
            double pagcom = 0;
            double pagcuo = 0;
            double cuo = 0;

            switch (Facultad)
            {
                case 1:              
                        Console.WriteLine("¿Que Carrera estudias?");
                        Console.WriteLine("1. MedicinaHu");
                        Console.WriteLine("2. Enfermeria");
                        Console.WriteLine("3. Psicologia");
                        Console.WriteLine("4. Nutricion");
                        Console.Write("Seleccione su Carrera de estudios [1-4]: ");
                        int CarMed = int.Parse(Console.ReadLine());
                    
                    switch (CarMed)
                    {
                        case 1: pagcic = 22500; break;
                        case 2: pagcic = 15300; break;
                        case 3: pagcic = 12000; break;
                        case 4: pagcic = 10000; break;
                    }
                    break;


                case 2: 
                
                        Console.WriteLine("¿Que Carrera estudias?");
                        Console.WriteLine("1. Electronica");
                        Console.WriteLine("2. Sistemas");
                        Console.WriteLine("3. Industrial");
                        Console.WriteLine("4. Mecatronica");
                        Console.Write("Seleccione su Carerra de estudios [1-4]: ");
                        int CarIng = int.Parse(Console.ReadLine());

                    switch (CarIng)
                    {
                        case 1: pagcic = 17000; break;
                        case 2: pagcic = 17500; break;
                        case 3: pagcic = 17500; break;
                        case 4: pagcic = 20300; break;
                    }
                    
                    break;
                
                case 3:
                
                        Console.WriteLine("¿Que Carrera estudias?");
                        Console.WriteLine("1. Administracion");
                        Console.WriteLine("2. Contabilidad");
                        Console.WriteLine("3. Marketing");
                        Console.Write("Seleccione su Carerra de estudios [1-3]: ");
                        int CarNeg = int.Parse(Console.ReadLine());

                    switch (CarNeg)
                    {
                        case 1: pagcic = 13500; break;
                        case 2: pagcic = 14000; break;
                        case 3: pagcic = 16700; break;
                    }
                    break;
                
                case 4:
                        Console.WriteLine("¿Que Carrera estudias?");
                        Console.WriteLine("1. Inicial");
                        Console.WriteLine("2. Primaria");
                        Console.WriteLine("3. Secundaria");
                        Console.Write("Seleccione su Carerra de estudios [1-3]: ");
                        int CarEdu = int.Parse(Console.ReadLine());

                    switch (CarEdu)
                    {
                        case 1: pagcic = 10000; break;
                        case 2: pagcic = 12000; break;
                        case 3: pagcic = 12000; break;
                    }
                    break;

                default:
                    
                        Console.WriteLine("Opcion no valida");
                  break;
            }
            
            if (Creditos >= 1 && Creditos <= 12)
            {
                pagcicfi = pagcic * 0.75;
                monpacre = pagcicfi /Creditos;
            }
            else if (Creditos > 12 && Creditos <= 22)
            {
                pagcicfi = pagcic * 1;
                monpacre = pagcicfi  / Creditos;
            }
            else if (Creditos > 22 && Creditos <= 26)
            {
                pagcicfi = pagcic * 1.15;
                monpacre = pagcicfi / Creditos;
            }
            else
            {
                Console.WriteLine("datos invalidos");
            }
            if (Nota >= 16)
            {
                pagcicfi = pagcicfi - (pagcic * 0.10);
                monpano = pagcic * 0.10;
            }
            if (Colegio == 1)
            {
                pagcicfi = pagcicfi - (pagcic * 0.15 );
                monpaco = pagcic * 0.15;
            }
            else if (Colegio == 2)
            {
                monpaco = 0;
            }
            if (pago == 1)
            {
                pagcicfi = pagcicfi - (pagcic * 0.05);
                pagcom = pagcicfi * 0.05;
            }
            if (pago == 2)
            {
                pagcicfi = pagcicfi + (pagcic * 0.05);
                pagcuo = pagcicfi * 0.05;
                cuo = pagcicfi / 5;
            }


            Console.WriteLine("\nSu pago del ciclo es de: " + pagcicfi);
            Console.WriteLine("\nEl monto a pagar de tu carrera es: "+ pagcic);
            Console.WriteLine("\nEl total de creditos que llevaras es de: " + Creditos);
            Console.WriteLine("\nEl monto a Pagar por creditos es de: "+ monpacre);
            Console.WriteLine("\nEl descuento que obtendras por tus notas es de: " + monpano);
            Console.WriteLine("\nEl descuento que obtendras por procedencia de Colegio (N/P) es de:" + monpaco);
            Console.WriteLine("\nEl Descuento por Pago completo es de: "+ pagcom);
            Console.WriteLine("\nEl Incremento por Pago en cuotas es de: " + pagcuo);
            Console.WriteLine("\nEl Pago por mes (5cuotas) es de: " + cuo);
            Console.WriteLine("\nEl monto total a pagar es de: "+ pagcicfi);
            Console.ReadKey();
        }
    }
}

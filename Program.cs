using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAREA
{
    class Program
    {
        static void Main(string[] args)
        {
            //colocar el nombre el procedimiento #1 - menu principal
            menu();
        }// fin al cuerpo principal del proyecto

        //PROCEMIDIMENTO #1 - MENU PRINCIPAL

        static void menu()
        {
            //LIMPIAR
            Console.Clear();           
            Console.WriteLine("PROPIEATRIO: DEREK GARCIA");
            Console.WriteLine("--------------------------");
            //declarando variables
            int W1 = 0;
            //MOSTRAR MENU DE OPCIONES

            Console.WriteLine("****----MENU DE OPCIONES ---- ****");
            Console.WriteLine("1. PROGRAMA 1: CALCULAR PROMEDIO DE 3 NOTAS");
            Console.WriteLine("2. PROGRAMA 2: AREA DE UN TRIANGULO");
            Console.WriteLine("3. SALIDA DEL PROGRAMA");
//INGRESAR LA OPCION DEL MENU 

            Console.Write(" ingrese numero de opcion: "); W1 = int.Parse(Console.ReadLine());
            switch(W1)
        {
                case 1:

                    PROGRAMA1();

                break;

                case 2:

                    PROGRAMA2();
                break;

                case 3:
                Environment.Exit(0);
                break;

                default:
                Console.WriteLine(" **** ---- ADVERTENCIA, NUMERO FUERA DE RANGO ---****");
                break;
        }
            // pausador
            Console.ReadKey();

             }// FIN DEL PPROCEDIMIENTO #1 - MENU PRINCIPAL

        // PROCEDIMEINTO #2 - PROMEDIO DE 3 NOTAS
        
        static void PROGRAMA1 ()
        { 

        //LIMPIAR
            Console.Clear();
             //LIMPIAR 
            Console.Clear();
            Console.WriteLine("PROPIEATRIO: DEREK GARCIA");
            Console.WriteLine("--------------------------");
            //declarando variables
            int N1 = 0, N2 = 0, N3 = 0, S = 0;  
            //MOSTRAR MENU DE OPCIONES
            Console.WriteLine(" **** ---- PROCEDIMIENTO #2 - CALCULAR EL PROMEDIO DE 3 NOTAS ---****");
            Console.Write("ingrese primera nota: ");  N1 = int.Parse(Console.ReadLine());
            Console.Write("ingrese segunda nota: ");  N2 = int.Parse(Console.ReadLine());
            Console.Write("ingrese tercera nota: ");  N3 = int.Parse(Console.ReadLine());
            //proceso

S = (N1 + N2 + N3)/3 ;

            //MOSTRAR RESULTADO

            Console.WriteLine(" EL PROMEDIO ES DE: " +S);
                //PAUSADOR

                Console.ReadKey();
            //RETORNO
            menu();
            }//FIN DEL PROCEDIMIENTO
         static void PROGRAMA2()
        { 
             //LIMPIAR 
            Console.Clear();
            Console.WriteLine("PROPIEATRIO: DEREK GARCIA");
            Console.WriteLine("--------------------------");
            //declarando variables
            int B = 0, A = 0,  S = 0;  
             //ingreso de valores
            Console.WriteLine(" **** ---- PROCEDIMIENTO #2 - CALCULAR EL AREA DE UN TRIANGULO ---****");
            Console.Write("ingrese la base: ");  B = int.Parse(Console.ReadLine());
            Console.Write("ingrese la altura: ");  A = int.Parse(Console.ReadLine());
//proceso
        S =  (B*A)/2 ; 
// MOSTRAR RESULTADO

             Console.WriteLine(" EL AREA DEL TRIANGULO ES: " + S);

             //pausador
             Console.ReadKey();
             //retorno
             menu();

         }//final del proceso
    }
}

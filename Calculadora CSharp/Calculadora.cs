using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_CSharp{

    public class Calculadora {

        public static double Suma(){
            double num = 0, valor = 0;
            Console.Write("Ingrese los numeros a sumar: ");
            num = double.Parse(Console.ReadLine());
            while(num != 0){
                valor += num;
                Console.Write("(Finalize con 0) Ingrese los numeros a sumar: ");
                num = double.Parse(Console.ReadLine());
            }
            return valor;
        }
        public static double Resta(){
            short i = 0;
            double num = 0, valor = 0, aux = 0;
            Console.Write("Ingrese los numeros para restar: ");
            num = double.Parse(Console.ReadLine());
            while(i < 2){
                if(num > 0 && aux < num){
                    aux = num;
                }
                else valor = aux - num;
                Console.Write("Ingrese los numeros para restar: ");
                num = double.Parse(Console.ReadLine());
                i++;
            }
            return valor;

        }
        public static double Multiplicacion(){
            short i = 0;
            double num = 0, valor = 0;
            Console.Write("Ingrese los numeros para multiplicar: ");
            num = double.Parse(Console.ReadLine());
            while (num != 0){
                if(i == 0){
                    valor = num;
                }
                else valor *= num;
                i++;
                Console.Write("(Finalize con 0) Ingrese los numeros para multiplicar: ");
                num = double.Parse(Console.ReadLine());
            }
            return valor;
        }

        public static double Division(){
            double num = 0, num2 = 0;
            Console.Write("Ingrese los numeros para dividir: ");
            num = double.Parse(Console.ReadLine());
            for (int i = 0; i < 1; i++){
                num2 = num;
                Console.Write("(Ingrese los numeros para dividir: ");
                num = double.Parse(Console.ReadLine());
            }
            return num2/num;
        }
        public static double Raiz(){
            double num = 0;
            Console.Write("Ingrese el numero para la raiz: ");
            num = double.Parse(Console.ReadLine());
            return Math.Sqrt(num);
        }
        public static double Potencia(){
            double num = 0, expo=0, valor=0;
            Console.Write("Ingrese el exponente: ");
            expo = double.Parse(Console.ReadLine());
            Console.Write("Ingrese el numero: ");
            num = double.Parse(Console.ReadLine());
            for(int i=0; i < expo; i++){
                if (i == 0){
                    valor = num;
                }
                else valor *= num;
            }
            return valor;
        }

        public static void Main(){

            char opcion;
            Console.WriteLine("\tCALCULADORA BY DI PRINZIO GUSTAVO\n");
            Console.WriteLine("*****     Ingrese la cuenta que desea hacer      *****");
            Console.WriteLine("*****     Suma -> S                              *****");
            Console.WriteLine("*****     Resta -> R                             *****");
            Console.WriteLine("*****     Multiplicacion -> M                    *****");
            Console.WriteLine("*****     Division -> D                          *****");
            Console.WriteLine("****      Raiz -> Q                              *****");
            Console.WriteLine("****      Potencia -> P                          *****");
            Console.WriteLine("****      Salir -> E                          *****");
            Console.Write("----> ");
            opcion = char.Parse(Console.ReadLine().ToUpper());

            while (opcion != 'E'){
                switch (opcion){
                    case 'S':
                        Console.WriteLine("La suma es " + Suma() + "\n\n");
                        break;
                    case 'R':
                        Console.WriteLine("La resta es " + Resta() + "\n\n");
                        break;
                    case 'M':
                        Console.WriteLine("La multiplicacion es " + Multiplicacion() + "\n\n");
                        break;
                    case 'D':
                        Console.WriteLine("La division es " + Division() + "\n\n");
                        break;
                    case 'Q':
                        Console.WriteLine("La raiz es " + Raiz() + "\n\n");
                        break;
                    case 'P':
                        Console.WriteLine("La potencia es " + Potencia() + "\n\n");
                        break;
                    default: Console.WriteLine("Funcion invalida"); break;
                }
                Console.WriteLine("*****     Ingrese la cuenta que desea hacer      *****");
                Console.WriteLine("*****     Suma -> S                              *****");
                Console.WriteLine("*****     Resta -> R                             *****");
                Console.WriteLine("*****     Multiplicacion -> M                    *****");
                Console.WriteLine("*****     Division -> D                          *****");
                Console.WriteLine("****      Raiz -> Q                              *****");
                Console.WriteLine("****      Potencia -> P                          *****");
                Console.Write("----> ");
                opcion = char.Parse(Console.ReadLine().ToUpper());
            }
            Console.WriteLine("\tHasta la proxima :)");
            Console.ReadKey();

        }

    }
}

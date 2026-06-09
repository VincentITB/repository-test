/*  int num;
    int a = 5;
    int b = a + 2;
    int a = 3, b = 15, c = 23;
    bool test = true;

constant es tipus especial de variable que te una particularitat: el seu valor només pot ser llegit mai modificat
const int MyMum = 15;
     
int / Numeros enteros // int edad = 18;
double / Numeros decimales // double altura = 1.75;
float / numeros decimales poca precision // float temperatura = 36.5f;
decimal / decimales para calculos financieros // decimal precio = 19.9m;
char / un unico caracter // char inicial = 'a'
string / cadena de texto // string nombre = "Maria";
bool / Valores true false // bool aprobado = true; 
long / Enteros muy grandes // long poblacion = 800000000L;
short / Enteros pequeños // short cantidad = 150 ; 
byte / Valores entre 0 y 255 // byte nivel = 100;


int x = 5;
int y = ++x;

Console.WriteLine(x); // 6
Console.WriteLine(y); // 6


int x = 5;
int y = x++;

Console.WriteLine(x); // 6
Console.WriteLine(y); // 5

casting de variables implicito, se hace automaticamente pq c# detecta
que no hay riesgo de perder informacion es decir pasar de un int a un float 

Casting explicito es cuando si que hay riesgo de que se pueda perder informacion
por ejemplo si pasas de un float a un it vas a perder los decimlaes 8.9 pasaria a 8 

*/

using System;
using System.Diagnostics;
using System.Runtime;
namespace HellowWorldProject {
    public class HelloWorld {
        public static void Main() 
        {
            //HolidayTime();
            // UsoDeIterativas();
            // RefactoredHoliday();
            ArrayCreator();
            Console.WriteLine("Dime un numero del 1 la 12 y te dire si ese numero es junio o no ");
            int mes;
            mes= Int32.Parse(Console.ReadLine());

            string isTrue = mes == 6 ? "es junio" : "no es junio ";
            Console.WriteLine(isTrue);
            numerosEnteros();
            mayorOmenor();
        }
        static void numerosEnteros()
        {
            int num; 
            Console.WriteLine("Introdueix un num: ");
            try
            {
                num = Int32.Parse(Console.ReadLine());
                Console.WriteLine("El valor introduit es {0}", num);
            }
            catch (FormatException)
            {
                Console.WriteLine("no has introducido un numero entero");
            }
            catch (OverflowException)
            {
                Console.WriteLine("El numero es massa gran");
            }
            catch (Exception)
            {
                Console.WriteLine("Error insesperat");
            }

        }
        static void mayorOmenor() 
        {
            int age; 
        Console.WriteLine("Dime cuantos años tienes:");
            age= Int32.Parse(Console.ReadLine());

            if (age < 18)
            {
                Console.WriteLine("Aun eres joven para beber");
            }
            else if (age >= 18 && age <= 21) 
            {
                Console.WriteLine("Ya eres mayorpero mejor bebe solo birra");
            }
            else
            {
                Console.WriteLine("Haz lo que te salga de las narices");    
            }
        }
        static void HolidayTime() 
        {
            int month;
           month=  Int32.Parse (Console.ReadLine());
            switch (month  )
            {
                case 1:
                    Console.WriteLine("January");
                    break;

                case 2:
                    Console.WriteLine("February");
                    break;

                case 3:
                    Console.WriteLine("February");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("study c# mdfk");
                    break;
                    default: Console.WriteLine("Some other month");
                    break;
            }
        }
        static void RefactoredHoliday()
        {
            int month;
            month = Int32.Parse(Console.ReadLine());
            string whatToDo = month switch
            {
                1 => "chill",
                2 => "se viene",
                3 => "girando la esquina",
                6 or 7 or 8 => "cagaste",
                _ => "otro mes random",
            };
            Console.WriteLine(whatToDo);
        }
        static void UsoDeIterativas() 
        {
            Console.WriteLine("Dime un numero del 1 al 3 para ver las iteraciones");

            int itNum;
            itNum = Int32.Parse(Console.ReadLine());
            int num = 0;
            switch (itNum)
            {
                case 1:
                    while (num <= 10)
                    {
                        Console.WriteLine("Iteracion numero: " + num);
                        num++;
                    }
                    Console.WriteLine("has usado el while loop");
                    break;

                case 2:
                    do {
                        Console.WriteLine("Iteracion numero: " + num);
                        num++;
                    } while (num <= 10);
                    Console.WriteLine("has usado el do while loop");
                    break;

                case 3:
                    num = 10;
                   // Console.WriteLine(num);
                    for (int i = 0; i <= 10; i++) 
                    {
                        Console.WriteLine("Iteracion numero: " + num);
                        num--;
                    }
                    Console.WriteLine("has usado el for");
                    break;     
                    
            }
            

        
        }
        static void ArrayCreator() 
        {
            int arrayX;
            Console.WriteLine("Esto es un generador de arrays. Bienvenido");
            Console.WriteLine("introduce el numeor de espacios que quieres que tenga la array:");
            arrayX = Int32.Parse(Console.ReadLine());
            int [] arrayNum  = new int[arrayX];
            Console.WriteLine("Ahora vas a ir introduciendo uno a uno los numeros que quieres que rellenen la array");
            for (int i = 0; i < arrayX; i++) 
            {
                Console.WriteLine("Escribe la cifra que ira en la posicion " + i);
                arrayNum[i]= int .Parse(Console.ReadLine());
            }
            Console.WriteLine("");
            Console.WriteLine("Tu array es:");
            Console.WriteLine(arrayNum);

            for (int i = 0; i < arrayX; i++)
            {
                Console.Write(arrayNum[i]+",");
            }
            Console.WriteLine();


        }
    }
}
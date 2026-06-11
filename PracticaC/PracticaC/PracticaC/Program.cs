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
using System.Linq.Expressions;
using System.Runtime;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
namespace HellowWorldProject {
    public class HelloWorld {
        public static void Main() 
        {
            /*int[] array = BubbleSorting();
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]}, ");
            }
            Console.WriteLine
            Arrays2D();
            HolidayTime();
            UsoDeIterativas();
            RefactoredHoliday();
            ArrayCreator();
            testForeach();
            Arrayfinder();
            Console.WriteLine("Dime un numero del 1 la 12 y te dire si ese numero es junio o no ");
            int mes;
            mes= Int32.Parse(Console.ReadLine());

            string isTrue = mes == 6 ? "es junio" : "no es junio ";
            Console.WriteLine(isTrue);
            numerosEnteros();
            mayorOmenor();
            */
            //StringPlay();
            //jaggeredArray();
            Bloc01Ac095();
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

            for (int i = 0; i < arrayX; i++)
            {
                Console.Write($"{arrayNum[i]}, ");
            }
            Console.WriteLine();
            Console.WriteLine($" Esto es lo que mide el array {arrayNum.GetLength(0)}");
        }
        static void testForeach() 
        {
            int position = 0;
            int[] arrayPred = { 1, 2, 3, 4, 200, 6, 7, 8, 9, 10 };
            foreach (int i in arrayPred)
            {
                     
                if (i==200)
                {
                    Console.WriteLine($"el valor que tu buscas esta en la posicion {position}");
                }
                position++;
                Console.WriteLine($"{i}");
            }

        }
        static void Arrayfinder() 
        {
            int index;
            int numCheck; 
            Console.WriteLine("aquesta es la maquina que et dira si el numero esta o no esta enn l'array");
            Console.WriteLine("digues de quans espais vols l'array");
            index= Int32.Parse(Console.ReadLine());
            int[] newArray = new int[index];
            bool founded = false;
            int foundedNum = 0;
            int x = 0;
            for (int i = 0; i < index; i++)
            {
                Console.WriteLine($"Escriu aqui el numero que anira en la {i}a posicio");
                newArray[i]= Int32.Parse(Console.ReadLine());
            }
            Console.WriteLine("ara digues un numero que t'agradaria confirmar qeu i es a la llista");
            numCheck = Int32.Parse(Console.ReadLine());
            while (x < newArray.Length)
            {
                if (newArray[x] == numCheck)
                {
                    founded = true;
                    foundedNum++;
                    x++;
                }
                else
                {
                    x++;
                }
            }
            Console.WriteLine(founded? $"si que esta un total de {foundedNum} cops": "no esta, mala suerte");

        }
        static int[] BubbleSorting(int[] array)
        {
            //array = {5,3,8,10,9,7,6,1,4};
            for (int i = 0; i < array.Length; i++) 
            {
                for (int j = 0; j < array.Length - 1; j++) 
                {
                    if (array[j] > array[j+1])
                    {
                        int aux = array[j + 1];
                        array[j+1]= array[j];
                        array [j] = aux;
                    }             
                }
            }
            return array;
        }
        static void Arrays2D() 
        {
            int col,fil = 0;
            Console.WriteLine("Este es el progrma que tepermite crear arrays en 2D");
            Console.Write("Indica cuantas filas quieres que tenga tu array:");
            fil = numeroValido();
            Console.WriteLine("Ahora indicame el numero de columnas");
            col = numeroValido();
            int[,] array2D = new int [fil, col];
            int sum = 0;
            for (int i = 0; i < fil; i++) 
            {
                for (int j = 0; j < col; j++)
                {
                    Console.WriteLine($"dime el numero que ira en la fila numero {i} y la columna numero {j}");
                    array2D[i, j] = numeroValido();
                }
            }
            for (int i = 0; i <fil; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write($"{array2D[i, j]} ");
                }
                Console.WriteLine();
            }
            foreach (int item in array2D)
            {
                sum +=item;
                Console.Write($"{item}");
            }
            Console.WriteLine($"sumado da un total de {sum}");
        }
        static void jaggeredArray() 
        {
            int num;
           
            Console.WriteLine("Dime cuantos arrays quieres tener");
            num = numeroValido();
            int[][] jaggeredArray = new int[num][];
            Console.WriteLine(jaggeredArray.Length);

            for (int i = 0; i < jaggeredArray.Length; i++) 
            {  
               if (i % 2 == 0)
               {
                   jaggeredArray[i] = new int[2];
               }
               else
               {
                   jaggeredArray[i] = new int[4];
               }       
            }
            for (int i = 0; i < jaggeredArray.Length; i++)
            {
                for (int j = 0; j < jaggeredArray[i].Length; j++)
                {
                    jaggeredArray[i][j] = j;
                }
            }
            for (int i = 0; i < jaggeredArray.Length; i++)
            {
                Console.Write($"Array {i} -> [ ");
                for (int j = 0; j < jaggeredArray[i].Length; j++) 
                {
                    Console.Write(jaggeredArray[i][j]);
                    if (jaggeredArray[i][j]< jaggeredArray[i].Length-1)
                    {
                        Console.Write(", ");
                    }
                }
                Console.WriteLine(" ]");
            }
        }
        static void StringPlay() 
        {/*
            Console.WriteLine("escribeme una palabra:");
            string palabra1 = Console.ReadLine();
            Console.WriteLine("Ahora otra y si son iguales te lo dire:");
            string palabra2 = Console.ReadLine();
            string isTrue = palabra1.Equals(palabra2) == true ? "es igual" : "no se parecen en nada";
            Console.WriteLine(isTrue);
            int index= palabra1.LastIndexOf ('a');
            Console.WriteLine(index);
            float hash= palabra1.GetHashCode();
            Console.WriteLine(hash);
            palabra1=palabra1.Replace('a', 'j');
            Console.WriteLine(palabra1);*/
            string text = Console.ReadLine();
            string[] palabras = text.Split(' ');
            for (int i = 0; i < palabras.Length; i++)
            {
                Console.WriteLine(palabras[i]);
            }
            
        }
        static void Bloc01Ac091() 
        {
            Console.WriteLine("Et donen 20 numeros i els ordenes en pars e inpars");
            Random random = new Random();
            int HowMany=20, HowManyPair = 0, HowManyOdd = 0;
            int[] arrayNumeros = new int[HowMany];
            int[] arrayPair = new int[20];
            int[] arrayOdd = new int[20];

            for (int i = 0; i < HowMany; i++)
            {
                int AleaNum = random.Next(0, 10);
                if (AleaNum % 2 == 0)
                {
                    arrayPair[HowManyPair] = AleaNum;
                    HowManyPair++;
                }
                else
                {
                    arrayOdd[HowManyOdd] = AleaNum;
                    HowManyOdd++;
                }
            }
            for (int j = 0; j < HowManyPair; j++)
            {
                Console.Write(arrayPair[j]);
            }
            Console.WriteLine();
            for (int i = 0; i < HowManyOdd; i++)
            {
                Console.Write(arrayOdd[i]);
            }
        }
        static void Bloc01Ac092()
        {
            bool Escape = false;
            int Delete,Option;
            Console.WriteLine("La pokedex del mercadona");
            string[] array = {"Pikachu", "Charmander", "Squirtle", "Bulbasaur", "Eevee", "Jigglypuff", "Meowth",
            "Psyduck", "Snorlax", "Gengar", "Machop", "Magikarp", "Vulpix", "Onix", "Abra" };
            
            while (Escape!=true)
            {
             Console.WriteLine("Tens estes opcions: 1 -> Veure la llista y eliminar una posicio // 0 -> Sortir");
             Option=Int32.Parse(Console.ReadLine());
                if (Option == 1)
                {
                    for (int i = 0; i < array.Length; i++)
                    {
                        Console.WriteLine($"[{i}]: {array[i]}");
                    }
                    Console.WriteLine("quina posicio vols eliminar?");
                    Delete = Int32.Parse(Console.ReadLine());
                    if (array[Delete] == "Empty")
                    {
                        Console.WriteLine("!!No tens cap pokemon en esta posicio!!");
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine($"{array[Delete]} alliberat");
                        Console.WriteLine();
                        array[Delete] = "Empty";
                    }


                    for (int i = 0; i < array.Length; i++)
                    {
                        Console.WriteLine($"[{i}]: {array[i]}");
                    }
                }
                else 
                {
                    Console.WriteLine("Adeu");
                    Escape= true;  
                }     
            }
        }

        static void Bloc01Ac093() 
        {
            Random rnd = new Random();
            int Num, pivot,search,searchCount=0;
            int[] Arrayrnd = new int[10];
            Console.WriteLine("Dime un valor para buscar:");
            search= Int32.Parse(Console.ReadLine());    
            for (int i = 0; i < Arrayrnd.Length; i++) 
            {
                Num = rnd.Next(0,9);
                if (Num==search)
                {
                    searchCount++;
                }
                Arrayrnd[i] = Num;
            }
            for (int i = 0; i < Arrayrnd.Length; i++)
            {
                Console.Write(Arrayrnd[i]);
            }
            Console.WriteLine() ;
            for (int i = 0; i < Arrayrnd.Length; i++)
            {
                Console.Write(Arrayrnd[9-i]);
            }
            Console.WriteLine();
            /* for (int i = 0; i < Arrayrnd.Length; i++)
             {
                 for (int j = 0; j < Arrayrnd.Length-1; j++)
                 {
                     if (Arrayrnd[j] > Arrayrnd[j+1])
                     {
                         pivot = Arrayrnd[j];

                         Arrayrnd[j] = Arrayrnd[j+1];
                         Arrayrnd[j + 1]= pivot;
                     }
                 }
             }
             */
            if (searchCount==0)
            {
                Console.WriteLine("Tu numero no ha salido");
            }
            else
            {
                Console.WriteLine($"Tu numero ha salido un total de {searchCount} veces");
            }
            BubbleSorting(Arrayrnd);
            for (int i = 0; i < Arrayrnd.Length; i++)
            {
                Console.Write(Arrayrnd[i]);
            }


        }
        static void Bloc01Ac095()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Random rnd = new Random();
            int level, rareType,power;
            decimal cost, weight;
            bool isRare;
            
            string[] oNameArray = {"Espasa", "Escut", "Poció","Arc"};
            string[] table = {"Nom", "Nivell", "Preu","Pes","Cost", "IsRareItem","RareType"};
            int[] oLevelArray = new int[oNameArray.Length];
            int[] oPowerlArray = new int[oNameArray.Length];
            decimal[] oCostArray = new decimal[oNameArray.Length];
            decimal[] oWeightArray = new decimal[oNameArray.Length];
            bool[] oIsRare= new bool[oNameArray.Length];
            string[] oRareType = { "Comú","Rar","Legendari","Ordinari" };
            string[] oRareTypeNew= new string[oNameArray.Length];

            for (int i = 0; i < oNameArray.Length; i++)
            {
                level=rnd.Next(1,10);
                power=rnd.Next(100,500);
                cost = (decimal)(rnd.NextDouble() * 200 + 50);
                weight = Math.Round((decimal)(rnd.NextDouble() * 8 + 1),1);
                isRare = rnd.Next(2)==0;
                rareType = rnd.Next(oRareType.Length-1);
                oLevelArray[i] = level;
                oCostArray[i] = cost;
                oPowerlArray[i] = power;
                oWeightArray[i] = weight;
                oIsRare[i] = isRare;
                if (isRare)
                {
                    oRareTypeNew[i] = oRareType[rareType];
                }
                else
                {
                   oRareTypeNew[i] = "Ordinari";
                }
            }
            /*for (int i = 0;i < table.Length; i++) 
            {
                Console.Write($"{table[i],-8}");
            }*/
            Console.WriteLine(
    $"{"Nom",-10} {"Nivell",-8} {"Poder",-8} {"Pes",-8} {"Cost€",-10} {"Rare?",-8} {"RareType"}");
            for (int i = 0; i < oNameArray.Length; i++) 
            {
                Console.WriteLine(
    $"{oNameArray[i],-10} {oLevelArray[i],-8} {oPowerlArray[i],-8} {oWeightArray[i],-8} {oCostArray[i],-10:F2} € {oIsRare[i],-8} {oRareTypeNew[i]}");
               // Console.Write($"{oNameArray[i]}     {oLevelArray[i]}     {oPowerlArray[i]}     {oWeightArray[i]}     {oCostArray[i]} €     {oIsRare[i]}     {oRareTypeNew[i]}");
               // Console.WriteLine();
            }               
        }
        static int numeroValido() 
        {
            int num;
            num = Int32.Parse(Console.ReadLine());
            while (num<=0)
            {
                Console.WriteLine("este numero no es valido");
                Console.WriteLine("Escribe un numero mayor que 0");
                num = Int32.Parse(Console.ReadLine());
            }
            //Console.WriteLine($"{num} es un buen numero");
            return num;
        }
    }
}
using System;
class Program
{
    //esto es un comentario para ver todo el tema de Modificaciones
    static void Main()
    {
        Console.WriteLine("Bienvenido damao caballero al fabuloso trnasformador de numeros binarios a decimales");
        Console.WriteLine("Tienes un total de 3 intentos, aprovechalos");
        Console.WriteLine("Si es usted tan amable haga el favor de introducir un numero binario");

        int intentos = 3;
        while (intentos > 0)
        {
            Console.WriteLine("intento numero " + intentos);
            string binario = Console.ReadLine();
            int resultado = BinariCalculator(binario);
            Console.WriteLine("Tu numero binario " + binario + " en decimal es " + resultado);
            intentos--;
        }

        Console.WriteLine("tambien te puedo sumar dos numeros");
        Console.WriteLine("Introduce el primer numero");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Introduce el segundo numero");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Aqui tienes tu resultado: " + SumardorDecosas(a, b));

        Console.WriteLine("gracias por participar");
    }
    static int BinariCalculator(String binari)
    {
        int ndecimal = 0;
        for (int i = 0; i < binari.Length; i++)
        {
            char bit = binari[binari.Length - 1 - i];

            if (bit != '1' && bit != '0')
            {
                Console.WriteLine("Lo siento, este no es un numero Binario: " + binari);
                i = binari.Length;
            }
            else if (bit == '1')
            {
                ndecimal += (int)Math.Pow(2, i);
            }
        }
        return ndecimal;
    }
    static int SumardorDecosas(int a, int b)
    {
        int c = 0;
        c = a + b;
        return c;
    }

}
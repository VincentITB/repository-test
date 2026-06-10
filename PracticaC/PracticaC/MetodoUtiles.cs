using System;

public class MetodosUtiles
{
	public MetodosUtiles()
	{
        public int numeroValido()
        {
            int num;
            num = Int32.Parse(Console.ReadLine());
            while (num <= 0)
            {
                Console.WriteLine("este numero no es valido");
                Console.WriteLine("Escribe un numero mayor que 0");
                num = Int32.Parse(Console.ReadLine());
            }
            Console.WriteLine($"{num} es un buen numero");
            return num;
        }
    }
}

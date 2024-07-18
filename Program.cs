namespace IfElsePractice;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Lutfen bir sayi giriniz:");
        int sayi= Convert.ToInt32(Console.ReadLine());
        if(sayi>10)
        {
            Console.WriteLine("Sayi ondan buyuktur.");
        }
        if (sayi == 10)
        {
            Console.WriteLine("Sayi ona esittir.");
        }
        if (sayi<10)
        {
            Console.WriteLine("Sayi ondan kucuktur.");
        }
        if(sayi%2==0)
        {
            Console.WriteLine("Sayi cift sayidir.");
        }
        else
        {
            Console.WriteLine("Sayi tek sayidir.");
        }

    }
}
    

    

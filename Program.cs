namespace asdwdwqfgq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int a, b, toplam,cıkarma,bolum,carpım;
            Console.WriteLine("Hesap Makinası");
            Console.WriteLine("Sayı giriniz=");
            a=Convert.ToInt16(Console.ReadLine());
            
            Console.WriteLine("Sayı  giriniz=");
            b=Convert.ToInt16(Console.ReadLine());
            Console.WriteLine();
            
            toplam = a + b;
            Console.WriteLine("toplam="+toplam);
            
            cıkarma = a - b;
            Console.WriteLine("cıkarma="+cıkarma);
            
            bolum = a / b;
            Console.WriteLine("bolum="+bolum);
            
            carpım = a * b;
            Console.WriteLine("carpım="+carpım);
            Console.ReadLine();


            
            


            

        }
    }
}

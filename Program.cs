namespace praktikum_task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("radiusni kiriting (input):");
            string radius = Console.ReadLine();
           int rad = Convert.ToInt32(radius);

            double S = Math.PI * (rad* rad);
            double L = 2*Math.PI * rad;

            Console.WriteLine($"Doira yuzasi(output):{S}");
            Console.WriteLine($"Aylana uzunligi (output):{L}");
           

            
        }
    }
}

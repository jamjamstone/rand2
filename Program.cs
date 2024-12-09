namespace rand2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            while (true) {
                //Console.WriteLine(rand.Next());
                //Console.WriteLine(rand.Next(0,10));
                //Console.WriteLine(rand.NextDouble());
                float myNum=(float)rand.Next(0,100)/100;// 소수점 랜덤 만들기
                Console.WriteLine(myNum);
            }
        }
    }
}

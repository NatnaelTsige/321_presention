namespace GoodImplementation
{
    public class Banana : IFruit
    {
        public void DisplayInfo(int num)
        {
            Console.WriteLine(num);
            Console.WriteLine("Banana!");
        }
    }
}
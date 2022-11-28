namespace GoodImplementation
{
    public class Apple : IFruit
    {
        public void DisplayInfo(int num)
        {
            Console.WriteLine(num);
            Console.WriteLine("Apple!");
        }
    }
}
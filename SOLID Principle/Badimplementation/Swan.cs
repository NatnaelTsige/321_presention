namespace BadImplementation
{
    public class Swan : Bird
    {
        public void eat()
        {
            Console.WriteLine("Lets eat seeds.");
        }

        public override void fly()
        {
            Console.WriteLine("Lets fly!");
        }
    }
}

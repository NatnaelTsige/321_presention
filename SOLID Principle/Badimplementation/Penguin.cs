namespace BadImplementation
{
    public class Penguin : Bird
    {
        public void eat()
        {
          Console.WriteLine("Can I eat taco?");
        }

        public override void fly()
        {
            throw new NotSupportedException("Help! I cannot fly!");
        }
    } 
}


namespace ProperImplemention
{
    public class Swan : FlyingBird
    {

        public override void eat()
        {   
           Console.WriteLine("eat aquatic vegetation!");
        }

        public override void fly()
        {
            Console.WriteLine("Fly away!");
        }
    }
}

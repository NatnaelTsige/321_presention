namespace BadImplementation
{
    public class RShapeManager
    {
        public double CumulativeArea(Rectangle[] shapes) 
        { 
            double area = 0;
            foreach (var shape in shapes) 
            {
                area += shape.Width * shape.Height;
            }
            return area;
        }
    }
}

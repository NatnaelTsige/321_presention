namespace ProperImplemention
{
    public class ShapeManager
    {
        public double CumulativeArea(Shape[] shapes)
        {
            double area = 0;
            foreach (var shape in shapes)
            {
                area += shape.Area();
            }

            return area;
        }
    }
}

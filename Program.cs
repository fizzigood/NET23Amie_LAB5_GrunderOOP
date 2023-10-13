namespace LAB5_NET23Amie_GrunderOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle5 = new Circle(5);
            Circle circle6= new Circle(6);
            Console.WriteLine("The area of a circle with a radius of 5 is; " + circle5.getArea());
            Console.WriteLine("The area of a circle with a radius of 6 is; " + circle6.getArea());
        }
        public class Circle
        {
            double Radius;

            public Circle(double Radius) 
            { 
                this.Radius = Radius;
            }
            public double getArea()
            {
                double Area = Math.PI * Radius * Radius;
                return Area;
            }

        }
    }
}
namespace Labb_3___Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Create a list of shapes of different geometry types.
            List<Geometry> shapes = new List<Geometry>()
            {
                new Circle(4), // Add circle with radius 4.
                new Square(8), // Add square with radius 8.
                new Rectangle(4,8), // Add rectangle with width 4 and height 8.
                new Triangle(4,8) // Add triangle with base 4 and height 8.
            };

            // Loop throught each shape in list and print its area.
            foreach (Geometry shape in shapes)
            {
                // Print the area of current shape.
                Console.WriteLine($"Area of {shape.GetType().Name}: {shape.Area()}");
                Console.ReadKey();
            }
            Console.WriteLine("_____________________");
            Console.ReadKey();
            Console.Clear(); // Clear console.

            // Output the choices for the user to choose.
            Console.WriteLine("Choose a shape to create: ");
            Console.WriteLine("1. Circle");
            Console.WriteLine("2. Square");
            Console.WriteLine("3. Rectangle");
            Console.WriteLine("4. Triangle");
            int choice; // Varianble to store the users choice.

            try
            {
                // Try to read the user choice as an int.
                choice = int.Parse(Console.ReadLine());

                {

                    // Switch the user choice and calculate its area.
                    switch (choice)
                    {
                        case 1:
                            // For cicle, ask for radius then calculate area.
                            Console.WriteLine("Enter the radius of the Circle in cm: ");
                            double circleradius = double.Parse(Console.ReadLine());
                            Circle circle = new Circle(circleradius);
                            Console.WriteLine($"Area of the circle is {circle.Area()}");
                            Console.ReadKey();
                            break;

                        case 2:
                            // For square, ask for the side of the square then calculate area.
                            Console.WriteLine("Enter the side of the Square in cm: ");
                            double squareside = double.Parse(Console.ReadLine());
                            Square square = new Square(squareside);
                            Console.WriteLine($"Area of the square is {square.Area()}");
                            Console.ReadKey();
                            break;
                        case 3:
                            // For rectangle, ask for widht and lenght then calculate area.
                            Console.WriteLine("Enter the width of your Rectangle in cm: ");
                            double rectanglewidth = double.Parse(Console.ReadLine());
                            Console.WriteLine("Enter the height of your Rectangle in cm: ");
                            double rectanglehight = double.Parse(Console.ReadLine());
                            Rectangle rectangle = new Rectangle(rectanglewidth, rectanglehight);
                            Console.WriteLine($"The Area of your Rectangle is {rectangle.Area()}");
                            Console.ReadKey();
                            break;
                        case 4:
                            // For triangle, ask for width and lenght then calculate area.
                            Console.WriteLine("Enter the width of your Triangle in cm: ");
                            double trianglewidht = double.Parse(Console.ReadLine());
                            Console.WriteLine("Enter the height of your Triangle in cm: ");
                            double triangleheight = double.Parse(Console.ReadLine());
                            Triangle triangle = new Triangle(trianglewidht, triangleheight);
                            Console.WriteLine($"The Area of your Triangle is {triangle.Area()}");
                            break;
                        default:
                            // If the user enter an invalid choice, print error message.
                            Console.WriteLine("Invalid choice!");
                            break;


                    }

                }
            }
            catch (FormatException) // Handle the case if the user inputs something other than a number.
            {
                Console.WriteLine("Invalid input!");
            }
            catch (Exception ex) // Handle any other errors and print the message.
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        // Abstract class, witch makes the other classes to implement the Area method.
        public abstract class Geometry
        {
            public abstract double Area();


        }

        // Cicle class that inherits from Geometry class.
        public class Circle : Geometry
        {
            public double Radius { get; set; } // Property to store radius.

            float _pi = 3.141f; // Value for pi.

            // Constructor to set the radius of the circle.
            public Circle(double radius)
            {
                Radius = radius;
            }

            // Override the Area method to calculate the area of a circle.
            public override double Area()
            {
                return Radius * Radius * _pi;
            }

        }

        // Square class that inherhits from Geometry.
        public class Square : Geometry
        {
            public double Side { get; set; } // Property to store side lenght.

            // Constructor to set the lenght of the square.
            public Square(double side)
            {
                Side = side;
            }
            // Override the Area method to calculate the area of a square.
            public override double Area()
            {
                return Side * Side;
            }
        }

        // Class rectangle that inherhits from Geometry.
        public class Rectangle : Geometry
        {
            public double Width { get; set; } // Property to store width.
            public double Height { get; set; } // Property to store height.

            // Constructor to set he width and lenght of the rectangle.
            public Rectangle(double width, double height)
            {
                Width = width;
                Height = height;
            }

            // Override the Area method to calculate the area of a rectangle.
            public override double Area()
            {
                return Width * Height;
            }
        }

        // Class triangle that inherits from Geometry.
        public class Triangle : Geometry
        {
            public double Height { get; set; } // Property to store height.
            public double Widht { get; set; } // Property to store width.

            // Constructor to set the width and heigt of the triangle.
            public Triangle(double width, double height)
            {
                Widht = width;
                Height = height;
            }

            // Override the Area method to calculate the area of a triangle. 
            public override double Area()
            {
                return Height * Widht / 2;
            }
        }
    }

}

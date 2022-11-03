class Program
{

    bool invalidinput = true;
    static public void Main()
    {
        Rectangle obj = new Rectangle();
        Program obj1 = new Program();
        Triangle obj2 = new Triangle();
        while (obj1.invalidinput == true)
        {
            try
            {
                Console.Write("Input your length ");
                obj.length = int.Parse(Console.ReadLine());
                Console.Write("Input your width ");
                obj.width = int.Parse(Console.ReadLine());
                break;
            }
            catch
            {
                Console.Write("Invalid input. ");
            }
        }
        Console.WriteLine("Area of your rectangle is " + obj.RectangleArea(obj.length, obj.width));
        obj.shapedeterminantforint(obj.length, obj.width);
        while (obj1.invalidinput == true)
        {
            try
            {
                Console.Write("Input your length ");
                obj.lengthforPerimeter = double.Parse(Console.ReadLine());
                Console.Write("Input your width ");
                obj.widthforPerimeter = double.Parse(Console.ReadLine());
                break;
            }
            catch
            {
                Console.Write("Invalid input. ");
            }
        }
        Console.WriteLine("Perimeter of your rectangle is " + obj.RectanglePerimeter(obj.lengthforPerimeter, obj.widthforPerimeter));
        obj.shapedeterminant(obj.lengthforPerimeter, obj.widthforPerimeter);
        while (obj1.invalidinput == true)
        {
            try
            {
                do{
                Console.WriteLine("Do not forget triangle's sides cannot be less than 0!");
                Console.Write("Input your side 1 ");
                obj2.side1 = double.Parse(Console.ReadLine());
                Console.Write("Input your side 2 ");
                obj2.side2 = double.Parse(Console.ReadLine());
                Console.Write("Input your side 3 ");
                obj2.side3 = double.Parse(Console.ReadLine());
                } while (obj2.side1 <= 0 || obj2.side2 <= 0 || obj2.side3 <= 0);
                do{
                Console.WriteLine("Do not forget that angles in sum cannot be greater and less than 180!");
                Console.Write("Input your angle 1 ");
                obj2.angle1 = double.Parse(Console.ReadLine());
                Console.Write("Input your angle 2 ");
                obj2.angle2 = double.Parse(Console.ReadLine());
                Console.Write("Input your angle 3 ");
                obj2.angle3 = double.Parse(Console.ReadLine());
                } while(obj2.angle1 + obj2.angle2 + obj2.angle3 != 180);
                break;
            }
            catch
            {
                Console.Write("Invalid input. ");
            }
        }
        obj2.triangledeterminant(obj2.side1, obj2.side2,obj2.side3, obj2.angle1, obj2.angle2, obj2.angle3);
        Console.ReadKey();
    }
}
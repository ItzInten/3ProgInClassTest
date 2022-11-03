class Rectangle {

    public int length;
    public int width;

    public double lengthforPerimeter;
    public double widthforPerimeter;
    double area;
    double perimeter;
    
    public double RectangleArea(int width, int length)
    {
        area = length * width;
        return area;
    }

    public double RectanglePerimeter(double lengthforPerimeter, double widthforPerimeter)
    {
        perimeter = 2 * lengthforPerimeter + 2 * widthforPerimeter;
        return perimeter;
    }

    public void shapedeterminant(double lengthforPerimeter, double widthforPerimeter)
    {
        if(lengthforPerimeter == widthforPerimeter)
        {
            Console.WriteLine("Your shape is square!");
        }
        else
        {
            Console.WriteLine("Your shape is rectangle!");
        }
    }

    public void shapedeterminantforint(int length, int width)
    {
        if(length == width)
        {
            Console.WriteLine("Your shape is square!");
        }
        else
        {
            Console.WriteLine("Your shape is rectangle!");
        }
    }
}
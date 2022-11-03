class Triangle
{
    public double side1,side2,side3;
    public double angle1,angle2,angle3;

     public void triangledeterminant(double side1, double side2, double side3, double angle1, double angle2, double angle3)
    {
        if ((side1 == side2) && (side1 == side3) && (angle1 == 60) && (angle2 == 60) && (angle3 == 60))
        {
            Console.WriteLine("Your triangle is Equilateral!");
        }
        else if (((side1 == side2) || (side2 == side3) || (side1 == side3)) && ((angle1 == angle2) || (angle2 == angle3) || (angle1 == angle3)))
        {
            if (((side1 == side2) && (side2 == side3)) && ((angle1 == 60) && (angle2 == 60) && (angle3 == 60)))
            {
                Console.WriteLine("Your triangle is Equilateral!");
            }
            Console.WriteLine("Your triangle is Isosceles!");
        }
        else 
        {
            Console.WriteLine("Your triangle is Scalene!");
        }
    }
}
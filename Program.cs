const double PI = 3.14159;

PrintCircleInfo(12);
PrintCircleInfo(24);

void PrintCircleInfo(int radius)
{
    Console.WriteLine($"Circle with radius {radius}");
    PrintCircleArea(radius);
    PrintCircleCircumference(radius);
}

void PrintCircleArea(int radius)
{
    double area = PI * (radius * radius);
    Console.WriteLine($"Area = {area}");
}

void PrintCircleCircumference(int radius)
{
    double circumference = 2 * PI * radius;
    Console.WriteLine($"Circumference = {circumference}");
}
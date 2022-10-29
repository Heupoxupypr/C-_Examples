double GetDis3D(int [] array)
{
double distance3D = Math.Sqrt(
Math.Pow(array[0] - array[3], 2)
+Math.Pow(array[1] - array[4], 2)
+Math.Pow(array[2] - array[5], 2));

return distance3D;
}

int GetNumber(string message)
{
Console.WriteLine(message);
return int.Parse(Console.ReadLine());
}

Point GetPoint()
{
Point point = new Point();

point.X = GetNumber("ВВедите кординаты для x");
point.Y = GetNumber("ВВедите кординаты для y");
point.Z = GetNumber("ВВедите кординаты для z");

return point;
}

Point firstPoint = GetPoint();
Point secondPoint = GetPoint();
double distance = GetDis3D(firstPoint, secondPoint);

Console.WriteLine($"Расстояние между точками равно = {distance}");


class Point
{
public int X { get; set; }
public int Y { get; set; }
public int Z { get; set; }
}
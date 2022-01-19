
using System;

class rectangle {
	
public delegate void rectDelegate(double height,
								double width);

	public void area(double height, double width)
	{
		Console.WriteLine("Area is: {0}", (width * height));
	}

	public void perimeter(double height, double width)
	{
		Console.WriteLine("Perimeter is: {0} ", 2 * (width + height));
	}


public static void Main(String []args)
{
	
	rectangle rect = new rectangle();

	rectDelegate rectdele = new rectDelegate(rect.area);
	
	rectdele += rect.perimeter;

	rectdele.Invoke(3.2, 1.2);
	Console.WriteLine();
	
	rectdele.Invoke(4.2, 4.5);
}
}

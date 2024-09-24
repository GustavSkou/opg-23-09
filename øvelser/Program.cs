double alængde = 3.4;
double abredde = 2.3;
double blængde = 1.4;
double bbredde = 6.3;
double areala = alængde*abredde;
double arealb = blængde*bbredde;

double størsteAreal (double a, double b)
{
	if (a>b)
	{
		Console.WriteLine("Største areal firkanten a");
		return a;
	}
	else 
	{
		Console.WriteLine("Største areal firkanten b");
		return b;
	}
}
Console.WriteLine(størsteAreal (areala,arealb));

double [] firkanta = {3.4,2.3};
double [] firkantb = new double [2];
firkantb [0] = 1.4;
firkantb [1] = 6.3;

double størsteFirkant (double [] firkanta, double [] firkantb)
{
	double areala = firkanta[0]*firkanta[1];
	double arealb = firkantb[0]*firkantb[1];
	
	if(areala>arealb)
	{
		Console.WriteLine("Største areal er firkanten a");
		return areala;
	}
	else 
	{
		Console.WriteLine("Største areal er firkanten b");
		return arealb;
	}
}
Console.WriteLine(størsteFirkant (firkanta,firkantb));

double [,] firkanter = { {3.4, 2.3} , {1.4, 6.3} };
	
	








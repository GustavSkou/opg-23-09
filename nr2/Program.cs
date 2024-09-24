char[,] firekant = new char[10,10];

for(int row = 0; row < 10; row++)
{
	for(int column = 0; column < 10; column++)
	{
		firekant[row, column] = '#';
	}
}


for(int row = 0; row < 10; row++)
{
	Console.WriteLine();
	for(int column = 0; column < 10; column++)
	{
		Console.Write("{0, 2}",firekant[row, column]);
	}
}


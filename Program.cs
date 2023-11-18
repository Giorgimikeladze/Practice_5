
int numb;
Console.Write("Enter integer value: ");
bool is_parsed = Int32.TryParse(Console.ReadLine(), out numb);

if (is_parsed && numb>=1)
{

	for (int i = 1; i <= numb; i++)
	{
		for (int j = 1; j <= i; j++)
		{
            // Console.Write(1);
            if (i % 2 == 1)
            {
                if (j % 2 == 1) {
                    Console.Write(1);
                }
                else {
                    Console.Write(0);
                }
               
            }
            else {
                if (j % 2 == 1)
                {
                    Console.Write(0);
                }
                else
                {
                    Console.Write(1);
                }
            }
        }
        Console.WriteLine();
    }

}
else {
    Console.WriteLine("invalid input!!!");
}

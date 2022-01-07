int rndm;
int ans, cnt = 0;
Random rnd = new Random();
do
{
	rndm = rnd.Next(0, 101);
	ans = Convert.ToInt32(Console.ReadLine());
	if (ans == rndm)
	{
		Console.WriteLine("Верно");
		Console.WriteLine($"{cnt} попыток");
	}
	else if (ans > rndm)
	{
		Console.WriteLine($"{ans} больше чем заданное число");
		cnt += 1;	
	}
	else if (ans < rndm)
	{
		Console.WriteLine($"{ans} меньше чем заданное число");
		cnt += 1;
	}
}
while (ans != rndm);
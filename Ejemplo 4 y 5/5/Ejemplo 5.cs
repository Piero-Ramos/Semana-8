using System;
					
public class Program
{
	public static void Main()
	{
		int n;
		double S = 0;
		Console.Write("Ingresar limite: ");
		n=int.Parse(Console.ReadLine());
		for (int i = 1; i <=n; i++)
		{
			S += (double)potencial(i, i) / factorial(i);
		}
		Console.WriteLine("Suma: {0}", S);
	}
	static double potencial(int bnum=1, int exp=1)
	{
		double res = 1;
		for (int i = 1; i <= exp; i++)
		{
			res *= bnum; 
		}
		return res;
	}
	static double factorial(int num)
	{
		double res = 1;
		for (int i = 1; i <= num; i++)
        {
            res *= i;
        }
        return res;
	}
}

using System;

public class Class1
{
	public Class1()
	{
		public static int main() { 
		public static int a[5] = new { s1, s2, s3, s4, s5 };
		int Total,Avg, HighestMark=0,i;
			Console.WriteLine("Get the Students Marks:");
			int s1 = s2 = s3 = s4 = Console.ReadLine("{0},{1},{2},{3}");
			int s5 = Console.ReadLine("{4}");
			Console.WriteLine("Get the total value:");
			Total = s1 + s2 + s3 + s4 + s5;
			Console.WriteLine("Average:", Total / 5);
			for (int i = 0; i < 5; i++)
			{
				if (a[i] > HighestMark)
					HighestMark = a[i];
			}

                Console.WriteLine("Highest Marks Among Five Students",HighestMark);
		
            }

        }


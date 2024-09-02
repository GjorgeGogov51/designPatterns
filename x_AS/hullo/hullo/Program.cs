namespace hullo
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Thread thread = new Thread(CountNumbers);

			thread.Start();

			for (int i = 0; i < 5; i++)
			{
				Console.WriteLine("Main thread: " + i);
				Thread.Sleep(500);
			}
			thread.Join();

			Console.WriteLine("Thread execution completed.");
		}

		public static void CountNumbers()
		{
			for (int i = 0; i < 5; i++)
			{
				Console.WriteLine("Second thread: " + i);
				Thread.Sleep(1000);
			}
		}
	}

	
}

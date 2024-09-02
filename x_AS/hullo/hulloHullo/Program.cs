namespace hulloHullo
{
	internal class Program
	{
		static async void Main(string[] args)
		{
			Task task = CountNumbersAsync();

			for (int i = 0; i < 5; i++)
			{
				Console.WriteLine("Main thread: " + i);
				await Task.Delay(500);
			}
			await task;

			Console.WriteLine("Task execution completed.");
		}

		static async Task CountNumbersAsync()
		{
			for (int i = 0; i < 5; i++)
			{
				Console.WriteLine("Task: " + i);
				await Task.Delay(1000);
			}
		}
	}
}

namespace ConsoleApp1
{
	public class Program
	{
		public static void Main(string[] args)
		{
			//Concurrency - single core, time sharing
			//Parallelism - multiple cores, multiple threads

			//Async doesn't create new threads (with synchronization context)
			//State machine - separated code segment execution

			new asTest().izvrsi().Wait(); // or don't
		}
	}
}

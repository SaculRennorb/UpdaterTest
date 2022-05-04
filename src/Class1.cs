using Rennorb.Logging;

namespace Test {
	public class Program {

		Logger logger = new("Main");

		bool shutdown_clean = false;

		public Program(Action request_stop)
		{

		}

		public int Main(string[] args)
		{
			Console.WriteLine("start");

			Thread.Sleep(3000);

			return shutdown_clean ? 0 : 1; //error
		}

		public void  ConsoleCommandReceived(string command)
		{
			shutdown_clean = true;
		}

		public void Stop()
		{
			logger.WriteLine("stop requested");
		}

	}
}
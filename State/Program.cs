namespace State;

internal sealed class Program
{
	private static void Main(string[] args)
	{
		Component component = new Component();
		component.Awake();
		while (true) 
		{
			component.Update();
			Thread.Sleep(1000);
		}
	}
}
namespace State.Entity.States;

internal class GreenState : BaseState
{
	public override void EnterState()
	{
		Console.ForegroundColor = ConsoleColor.Green;
		Console.WriteLine($"{this.GetType().Name}");
		Console.ResetColor();
	}
}
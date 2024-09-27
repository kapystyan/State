namespace State.Entity.States;

internal class RedState : BaseState
{
	public override void EnterState()
	{
		Console.ForegroundColor = ConsoleColor.Red;
		Console.WriteLine($"{this.GetType().Name}");
		Console.ResetColor();
	}
}

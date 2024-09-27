namespace State.Entity.States;

internal abstract class BaseState
{
	public virtual void EnterState() { }
	public virtual void ExitState() { }
}
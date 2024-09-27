using State.Entity.States;

namespace State.Entity;

internal sealed class TrafficLight
{
    private Dictionary<Type, BaseState> _states;

    public TrafficLight()
    {
        _states = new Dictionary<Type, BaseState>();
    }

    public BaseState? CurrentState { get; private set; }

    public void AddState(BaseState state)
    {
        if(state is null)
            throw new ArgumentNullException(nameof(state));
        var type = state.GetType();
        if (_states.TryGetValue(type, out var value))
        {
            Console.WriteLine($"State \'{type.Name}\' is already in entity data");
            return;
        }
        _states.Add(type, state);
    }
    public void SetState<T>() where T : BaseState
    {
        if (CurrentState is T)
        {
            Console.WriteLine($"Current state is already \'{nameof(T)}\'");
            return;
        }
        var type = typeof(T);
        if (_states.TryGetValue(type, out var value))
        {
            CurrentState?.ExitState();
            CurrentState = value;
            CurrentState.EnterState();
        }
        else
            Console.WriteLine($"State \'{type.Name}\' not exist in entity data");
    }
}

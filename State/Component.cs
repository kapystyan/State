using State.Entity;
using State.Entity.States;

namespace State
{
	internal sealed class Component // <- типо компонент
	{
		private TrafficLight _trafficLight = new TrafficLight();
		private int _timer = 4;

		public void Awake() // <- типо MonoBehavior.Awake()
		{
			_trafficLight.AddState(new GreenState());
			_trafficLight.AddState(new RedState());
		}
		public void Update()// <- типо MonoBehavior.Update()
		{
			if (_timer == 4)
				_trafficLight.SetState<GreenState>();
			_timer--;
			if(_timer == 2)
				_trafficLight.SetState<RedState>();
			if (_timer == 0)
				_timer = 4;
		}
	}
}

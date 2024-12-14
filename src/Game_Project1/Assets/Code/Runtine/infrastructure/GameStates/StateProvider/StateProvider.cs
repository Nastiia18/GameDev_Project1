using Code.Runtine.infrastructure.GameStates.API;
using Zenject;

namespace Code.Runtine.infrastructure.GameStates.StateProvider
{
    public class StateProvider : IStateProvider
    {
        private readonly DiContainer _container;
        
        public StateProvider(DiContainer container)
        {
            _container = container;
        }
        public TState GetState<TState>()
            where TState : class, IState =>
            _container.Resolve<TState>();
    }
}
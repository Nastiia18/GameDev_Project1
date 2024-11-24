using Code.Runtine.infrastructure.GameStates.API;

namespace Code.Runtine.infrastructure.GameStates.StateProvider
{
    public interface IStateProvider
    {
        TState GetState<TState>() 
            where TState : class, IEnterableState;
    }
}
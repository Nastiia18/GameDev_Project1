using Code.Runtine.infrastructure.GameStates.API;

namespace Code.Runtine.infrastructure.GameStates.StateMachine
{
    public interface IGameStateMachine
    {
        void Enter<TState>()
            where TState : class, IEnterableState;

        void Enter<TState, TPayLoad>(TPayLoad payload)
            where TState : class, IPlayLoadedEnterableState<TPayLoad>;
    }
}
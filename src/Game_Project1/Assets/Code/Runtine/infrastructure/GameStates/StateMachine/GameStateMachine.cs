using Code.Runtine.infrastructure.GameStates.API;
using Code.Runtine.infrastructure.GameStates.StateProvider;
using UnityEngine;

namespace Code.Runtine.infrastructure.GameStates.StateMachine
{
    public class GameStateMachine : IGameStateMachine
    {
        private readonly IStateProvider _stateProvider;
        private IState _activeState;

        public GameStateMachine(IStateProvider stateProvider)
        {
            _stateProvider = stateProvider;
        }
        
        public void Enter<TState>()
            where TState : class, IEnterableState
        {
            IEnterableState state = GetState<TState>();
            if(_activeState is IExitableState activeState) 
                activeState?.Exit();
           
            Debug.Log($"GameStateMachine entered: <color=#7CB9E8>{state.GetType().Name}</color>");
            state.Enter();
        }

        public void Enter<TState, TPayLoad>(TPayLoad payload)
            where TState : class, IPlayLoadedEnterableState<TPayLoad>
        {
            IPlayLoadedEnterableState<TPayLoad> state = GetState<TState>();
            if(_activeState is IExitableState activeState) 
                activeState?.Exit();
           
            Debug.Log($"GameStateMachine entered: <color=#7CB9E8>{state.GetType().Name}</color>");
            state.Enter(payload);
        }
        private TState GetState<TState>()
            where TState : class,IState=>
             _stateProvider.GetState<TState>();
        
    }
}
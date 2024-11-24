using System.ComponentModel;
using Code.Runtine.infrastructure.GameStates.API;
using Code.Runtine.infrastructure.GameStates.StateMachine;
using Code.Runtine.infrastructure.GameStates.State;
using Code.Runtine.infrastructure.Services.Scene;

namespace Code.Runtine.infrastructure.GameStates.State
{
    public class BootstrapState:IEnterableState
    {
        private const string LevelName = "Level";
        private const string BootstrapSceneName = "BootstrapScenes";
        
        private readonly IGameStateMachine _stateMachine;
        private readonly ISceneLoader _sceneLoader;

        public BootstrapState(IGameStateMachine stateMachine, ISceneLoader sceneLoader)
        {
            _stateMachine = stateMachine;
            _sceneLoader = sceneLoader;
        }
        public void Enter()
        {
            _sceneLoader.LoadScene(BootstrapSceneName);
            //
            _sceneLoader.LoadScene(LevelName);
            _stateMachine.Enter<LavelState>();
        }

    }
}
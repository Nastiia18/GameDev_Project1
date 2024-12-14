using System.ComponentModel;
using Code.Runtine.infrastructure.GameStates.API;
using Code.Runtine.infrastructure.GameStates.StateMachine;
using Code.Runtine.infrastructure.GameStates.State;
using Code.Runtine.infrastructure.Services.Scene;
using Code.Runtine.infrastructure.Services.StaticData;

namespace Code.Runtine.infrastructure.GameStates.State
{
    public class BootstrapState:IEnterableState
    {
        public IStaticDataService StaticDataService { get; }
        private const string LevelName = "Level";
        private const string BootstrapSceneName = "BootstrapScenes";
        
        private readonly IGameStateMachine _stateMachine;
        private readonly ISceneLoader _sceneLoader;
        private readonly IStaticDataService _staticDataService;

        public BootstrapState(IGameStateMachine stateMachine, ISceneLoader sceneLoader, IStaticDataService staticDataService)
        {
            _staticDataService = staticDataService;
            _stateMachine = stateMachine;
            _sceneLoader = sceneLoader;
           

        }
        public void Enter()
        {
            _sceneLoader.LoadScene(BootstrapSceneName);
            _staticDataService.LoadAll();
            _sceneLoader.LoadScene(LevelName);
            _stateMachine.Enter<LoadLevelState, string>("Level");
        }

    }
}
using Code.Runtine.Gameplay.Markers;
using Code.Runtine.infrastructure.Factories;
using Code.Runtine.infrastructure.GameStates.API;
using Code.Runtine.infrastructure.GameStates.StateMachine;
using Code.Runtine.infrastructure.Services.Scene;
using Code.Runtine.infrastructure.Services.StaticData;
using Code.Runtine.StaticData;
using UnityEngine;

namespace Code.Runtine.infrastructure.GameStates.State
{
    public class LoadLevelState: IPlayLoadedEnterableState<string>
    {
       private readonly ISceneLoader _sceneLoader;
       private readonly IGameStateMachine _stateMachine;
       private readonly IGameFactory _gameFactory;
       private readonly IStaticDataService _staticDataService;

       public LoadLevelState(
           ISceneLoader sceneLoader,
           IStaticDataService staticDataService, 
           IGameStateMachine stateMachine,
           IGameFactory gameFactory)
       {
           _sceneLoader = sceneLoader;
          
           _stateMachine = stateMachine;
           _gameFactory = gameFactory;
           _staticDataService = staticDataService;
       }
        public void Enter(string payload)
        {
            _sceneLoader.LoadScene(payload);

            LevelData levelData = _staticDataService.GetLevelData(payload);
            GameObject spawnPlayer = _gameFactory.CreatePlayer(levelData.PlayerSpawnPoint);
            _gameFactory.CreateHud(spawnPlayer);
            _stateMachine.Enter<LavelState>();
        }
    }
}

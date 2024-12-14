using Code.Runtine.Gameplay.Markers;
using Code.Runtine.infrastructure.Factories;
using Code.Runtine.infrastructure.GameStates.API;
using Code.Runtine.infrastructure.GameStates.StateMachine;
using Code.Runtine.infrastructure.Services.Scene;
using Code.Runtine.infrastructure.Services.StaticData;
using UnityEngine;

namespace Code.Runtine.infrastructure.GameStates.State
{
    public class LoadLevelState: IPlayLoadedEnterableState<string>
    {
       private readonly ISceneLoader _sceneLoader;
      private readonly IGameStateMachine _stateMachine;
       private readonly IGameFactory _gameFactory;

       public LoadLevelState(
           ISceneLoader sceneLoader,
           IStaticDataService staticDataService, 
           IGameStateMachine stateMachine,
           IGameFactory gameFactory)
       {
           _sceneLoader = sceneLoader;
          
           _stateMachine = stateMachine;
           _gameFactory = gameFactory;
       }
        public void Enter(string payload)
        {
            _sceneLoader.LoadScene(payload);
            GameObject spawnPlayer = SpawnPlayer();
            _gameFactory.CreateHud(spawnPlayer);
            _stateMachine.Enter<LavelState>();
        }

        private GameObject SpawnPlayer()
        {
            Vector3 playerSpawnPosition = Object.FindObjectOfType<PlayerSpawnPoint>().transform.position;

            return _gameFactory.CreatePlayer(playerSpawnPosition);
        }
    }
}

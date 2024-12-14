using Code.Runtine.infrastructure.GameStates.API;
using Code.Runtine.infrastructure.Services.Input;
using Code.Runtine.infrastructure.Services.StaticData;
using Unity.VisualScripting;
using UnityEngine;

namespace Code.Runtine.infrastructure.GameStates.State
{
    public class LavelState : IEnterableState, IExitableState
    {
        private IInputService _inputService;
        private readonly IStaticDataService _staticDataService;
       

        public LavelState(
            IInputService inputService, 
            IStaticDataService staticDataService)
        {
            _inputService = inputService;
            _staticDataService = staticDataService;
          
        }

        public void Enter()
        {
            _inputService.Enable();
            Debug.Log($"Start heath of play in config is {_staticDataService.PlayerConfig.Starthealth}");
        }

        public void Exit()
        {
            _inputService.Disable();
        }
    }
}
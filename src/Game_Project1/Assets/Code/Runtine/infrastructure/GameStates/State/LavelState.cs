using Code.Runtine.infrastructure.GameStates.API;
using Code.Runtine.infrastructure.Services.Input;

namespace Code.Runtine.infrastructure.GameStates.State
{
    public class LavelState:IEnterableState, IExitableState
    {
        private IInputService _inputService;

        public LavelState(IInputService inputService)
        {
            _inputService = inputService;
        }
        public void Enter() => 
            _inputService.Enable();

        public void Exit() =>
            _inputService.Disable();
    }
}
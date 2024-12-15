using Code.Runtine.infrastructure.GameStates.API;
using Code.Runtine.infrastructure.Services.Scene;

namespace Code.Runtine.infrastructure.GameStates.State
{
    public class ManeState:IEnterableState
    {
        private const string ManuNameScene = "Manu";
        private readonly ISceneLoader _sceneLoader;

        public ManeState(ISceneLoader sceneLoader)
        {
            _sceneLoader = sceneLoader;
        }
        public void Enter()
        {
            _sceneLoader.LoadScene(ManuNameScene);
        }
    }
}
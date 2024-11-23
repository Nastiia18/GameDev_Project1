using UnityEngine.SceneManagement;

namespace Code.Runtine.infrastructure.Services.Scene
{
    internal sealed class SceneLoader : ISceneLoader
    {
        public void LoadScene(string sceneName) =>
            SceneManager.LoadScene(sceneName);
    }
}
using Code.Runtine.infrastructure.Services.Random;
using UnityEngine.SceneManagement;
using Zenject;
namespace Code.Runtine.infrastructure
{
    public class ProjectInstaller:MonoInstaller, IInitializable
    {
        public override void InstallBindings()
        {
            Container.Bind<IRandomServices>().To<RandomServices>().AsSingle();
            Container.BindInterfacesAndSelfTo<ProjectInstaller>().FromInstance(this).AsSingle();
        }

        public void Initialize()
        {
            SceneManager.LoadScene("Level");
        }
    }
}
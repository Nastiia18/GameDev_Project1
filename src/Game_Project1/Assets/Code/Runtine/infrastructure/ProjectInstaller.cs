using Code.Runtine.infrastructure.Services.Input;
using Code.Runtine.infrastructure.Services.Random;
using Code.Runtine.infrastructure.Services.Scene;
using UnityEngine.SceneManagement;
using Zenject;
namespace Code.Runtine.infrastructure
{
    public class ProjectInstaller:MonoInstaller, IInitializable
    {
        public override void InstallBindings()
        {
            Container.Bind<IRandomServices>().To<RandomServices>().AsSingle();
            Container.Bind<ISceneLoader>().To<SceneLoader>().AsSingle();
            Container.Bind<IInputService>().To<InputService>().AsSingle();

            Container.BindInterfacesAndSelfTo<ProjectInstaller>().FromInstance(this).AsSingle();
        }

        public void Initialize()
        {
           Container
               .Resolve<ISceneLoader>()
               .LoadScene("Level");
        }
    }
}
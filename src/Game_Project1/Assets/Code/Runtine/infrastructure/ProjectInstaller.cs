using Code.Runtine.infrastructure.Factories;
using Code.Runtine.infrastructure.GameStates.StateMachine;
using Code.Runtine.infrastructure.GameStates.StateProvider;
using Code.Runtine.infrastructure.Services.Input;
using Code.Runtine.infrastructure.Services.Random;
using Code.Runtine.infrastructure.Services.Scene;
using Code.Runtine.infrastructure.GameStates.State;
using Code.Runtine.infrastructure.Services.StaticData;
using UnityEngine.SceneManagement;
using Zenject;
namespace Code.Runtine.infrastructure
{
    public class ProjectInstaller:MonoInstaller, IInitializable
    {
        public override void InstallBindings()
        {
            BindInfrastructureServices();
            BindFactories();
            BindGameStates();
            Container.BindInterfacesAndSelfTo<ProjectInstaller>().FromInstance(this).AsSingle();
        }



        private void BindGameStates()
        {
            Container.Bind<IStateProvider>().To<StateProvider>().AsSingle();
          
            
            Container.BindInterfacesAndSelfTo<ManeState>().AsSingle();
            Container.Bind<IGameStateMachine>().To<GameStateMachine>().AsSingle();
            Container.BindInterfacesAndSelfTo<BootstrapState>().AsSingle();
            Container.BindInterfacesAndSelfTo<LoadLevelState>().AsSingle();
            Container.BindInterfacesAndSelfTo<LavelState>().AsSingle();
        }

        private void BindInfrastructureServices()
        {
            Container.Bind<IRandomServices>().To<RandomServices>().AsSingle();
            Container.Bind<ISceneLoader>().To<SceneLoader>().AsSingle();
            Container.Bind<IInputService>().To<InputService>().AsSingle();
            Container.Bind<IStaticDataService>().To<StaticDataService>().AsSingle();
        }
   
        private void BindFactories()=>
           Container.Bind<IGameFactory>().To<GameFactory>().AsSingle();
        

        public void Initialize() =>
            Container
                .Resolve<IGameStateMachine>()
                .Enter<BootstrapState>();
    }
}

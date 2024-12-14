namespace Code.Runtine.infrastructure.GameStates.API
{
    public interface IPlayLoadedEnterableState<in TPlayLoaded> : IState
    {
        void Enter(TPlayLoaded payload);
    }
}
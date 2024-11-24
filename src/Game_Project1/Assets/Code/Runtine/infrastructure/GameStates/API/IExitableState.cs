namespace Code.Runtine.infrastructure.GameStates.API
{
    public interface IExitableState : IState
    {
        void Exit();
    }
}
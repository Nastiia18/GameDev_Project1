namespace Code.Runtine.infrastructure.GameStates.API
{

    public interface IEnterableState : IState
    {
        void Enter();
    }
}
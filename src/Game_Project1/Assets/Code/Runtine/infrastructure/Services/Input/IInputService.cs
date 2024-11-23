namespace Code.Runtine.infrastructure.Services.Input
{
    public interface IInputService
    {
        void Enable();
        void Disable();
        float GetMovement();
    }
}
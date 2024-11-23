namespace Code.Runtine.infrastructure.Services.Input
{
    public class InputService : IInputService
    {
        private const string AxisHorisontal = "Horizontal";
        private bool _enabled = true;

        public void Enable() => _enabled = true;

        public void Disable() => _enabled = false;

        public float GetMovement() => _enabled ? UnityEngine.Input.GetAxis(AxisHorisontal) : 0;
    }
}
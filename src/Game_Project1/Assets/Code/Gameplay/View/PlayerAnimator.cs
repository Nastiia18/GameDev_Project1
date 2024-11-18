using Code.Gameplay.Logic;
using UnityEngine;

namespace Code.Gameplay.View
{
    internal sealed class PlayerAnimator: MonoBehaviour
    {
        private static readonly int IsRuning = Animator.StringToHash("isRuning");

        [SerializeField]
        private Animator _animator;

        [SerializeField]
        private MoverX _moverX;

        private void Update()
        {
            _animator.SetBool(IsRuning, _moverX.IsMover);
        }
    }
}
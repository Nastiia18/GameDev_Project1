using System;
using Code.Extensions;
using UnityEngine;

namespace Code.Gameplay
{
    internal sealed class MoveView:MonoBehaviour
    {
        [SerializeField] 
        private MoverX _moverX;

        private void Update()
        {
            float sign = Math.Sign(_moverX.Speed);
            
             if(sign ==0)
                  return;


             float x = sign * Mathf.Abs(transform.localScale.x);
             transform.localScale = transform.localScale.SetX(x);


        }
    }
}
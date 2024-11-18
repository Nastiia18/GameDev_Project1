using UnityEngine;

namespace Code.Extensions
{
    public static class Vecto3Extensions
    {
        public static Vector3 SetX(this Vector3 vector, float x) =>
            new Vector3(x, vector.y, vector.z);
        
    }
}
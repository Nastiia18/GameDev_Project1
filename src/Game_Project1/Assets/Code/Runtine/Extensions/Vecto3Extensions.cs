using UnityEngine;

namespace Code.Runtine.Extensions
{
    public static class Vecto3Extensions
    {
        public static Vector3 SetX(this Vector3 vector, float x) =>
            new Vector3(x, vector.y, vector.z);
        
        public static Vector3 AddX(this Vector3 vector3, float x) =>
        vector3.SetX(vector3.x + x);
    }
}
using UnityEngine;
using Code.Runtine.Extensions;
using Code.Runtine.Gameplay.Logic;
using UnityEditor;

namespace Code.Editor
{
    [CustomEditor(typeof(ColectableSpawner))]
    internal sealed class CollectablesSpawnerEditor: UnityEditor.Editor
    {
        private const float RandomXRangeThickness = 3;
        [DrawGizmo(GizmoType.Active | GizmoType.Selected | GizmoType.NonSelected)]
        public static void RenderCustomGizmo(ColectableSpawner spawner, GizmoType gizmoType)
        {
            Handles.color= Color.yellow;
            Vector3 position = spawner.transform.position;
            Handles.DrawLine(position.SetX(spawner.RandomDeltaX),
                position.SetX(-spawner.RandomDeltaX),RandomXRangeThickness);
        }
    }
}
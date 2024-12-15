using System.Runtime.Serialization;
using Code.Runtine.Gameplay.Markers;
using Code.Runtine.StaticData;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Code.Editor
{
    [CustomEditor(typeof(LevelData))]
    public class LevelStaticDataEditor: UnityEditor.Editor
    {
        public override void OnInspectorGUI()
        {
            EditorGUI.BeginDisabledGroup(true);
            base.OnInspectorGUI();
            EditorGUI.EndDisabledGroup();
            
            if (GUILayout.Button("Collect data")) 
                CollectionData();
        }

        private void CollectionData()
        {
            LevelData levelData =(LevelData) target;
           levelData.LevelName = SceneManager.GetActiveScene().name;
           levelData.PlayerSpawnPoint = FindObjectOfType<PlayerSpawnPoint>().transform.position;
        }
    }
}
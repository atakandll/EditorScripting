using UnityEditor;
using UnityEngine;

namespace Editor
{
    [CustomEditor(typeof(LevelScript))]
    public class LevelScriptEditor : UnityEditor.Editor
    {
        public override void OnInspectorGUI()
        {
            LevelScript levelScript = (LevelScript)target;
            levelScript.experince = EditorGUILayout.IntField("Experince", levelScript.experince);
            EditorGUILayout.LabelField("Level", levelScript.Level.ToString());
        }
    }
}

using UnityEditor;

namespace EditorDic
{
    [CustomEditor(typeof(LevelScript))]
    public class LevelScriptEditor :Editor
    { 
        public override void OnInspectorGUI()
        {
            LevelScript levelScript = (LevelScript)target;
            levelScript.experince = EditorGUILayout.IntField("Experince", levelScript.experince);
            EditorGUILayout.LabelField("Level", levelScript.Level.ToString());
        }
    }
}

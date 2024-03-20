using UnityEditor;
using UnityEngine;

namespace EditorDic
{
    [CustomEditor(typeof(ObjectBuilder))]
    public class ObjectBuilderEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            DrawDefaultInspector();
            
            ObjectBuilder objectBuilder = (ObjectBuilder)target;

            if (GUILayout.Button("Create"))
            {
                objectBuilder.Create();
            }

        }
    }
}
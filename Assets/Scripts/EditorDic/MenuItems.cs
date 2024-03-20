using UnityEditor;
using UnityEngine;

namespace EditorDic
{
    public class MenuItems : MonoBehaviour
    {
        [MenuItem("Tools/Clear PlayerPrefs")]
        private static void NewMenuOptions()
        {
            PlayerPrefs.DeleteAll();
        }
        
    }
}
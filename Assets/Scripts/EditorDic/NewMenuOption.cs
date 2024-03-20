using UnityEditor;
using UnityEngine;


namespace EditorDic
{
    public class NewMenuOption
    {
        [MenuItem("CONTEXT/Rigidbody/new menu option")]
        private static void NewMenuOptions(MenuCommand command)
        {
            Rigidbody body = (Rigidbody)command.context;
            body.mass = 5;
            Debug.Log("Changed Rigidbody's Mass to " + body.mass + " from Context Menu...");
        }
    }
}
using UnityEngine;

namespace EditorDic
{
    public class NameBehaviour : MonoBehaviour
    {
        [ContextMenuItem("Randomize Name", "Randomize")]
        public string Name;

        private void Randomize()
        {
            Name = "Some Random Name";
        }
    }
}

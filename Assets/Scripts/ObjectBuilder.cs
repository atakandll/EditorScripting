using UnityEngine;

public class ObjectBuilder : MonoBehaviour
{
        public GameObject prefab;
        public Vector3 position;

        public void Create()
        { 
                Instantiate(prefab, position, Quaternion.identity);
        }
}
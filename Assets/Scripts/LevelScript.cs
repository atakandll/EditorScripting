using UnityEngine;

public class LevelScript : MonoBehaviour
{
    public int experince;

    public int Level
    {
        get { return experince / 100; }
    }
}
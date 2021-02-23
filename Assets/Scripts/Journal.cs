using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Journal : MonoBehaviour
{
    public TextAsset mission;
    List<string> missions = new List<string>();
    // Start is called before the first frame update
    void Start()
    {
        string[] texts = mission.text.Split('\n');
        missions = new List<string>(texts);
    }
}

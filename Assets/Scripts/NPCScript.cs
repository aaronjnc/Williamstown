using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCScript : MonoBehaviour
{
    public TextAsset npcdialog;
    public Sprite headshot;
    string npcname;
    public GameObject othernpc;
    public bool first = true;
    void Start()
    {
        npcname = gameObject.name;
    }
    public string GetName()
    {
        return npcname;
    }
}

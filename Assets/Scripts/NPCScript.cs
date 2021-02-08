using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCScript : MonoBehaviour
{
    public Sprite headshot;
    string name;
    void Start()
    {
        name = gameObject.name;
    }
    public string GetName()
    {
        return name;
    }
}

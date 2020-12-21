using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public bool bus = true;
    public Vector2 position;
    public NewScene sceneloader;
    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
}

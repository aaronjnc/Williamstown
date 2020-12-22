using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public bool bus = true;
    public List<Vector2> position = new List<Vector2>();
    public NewScene sceneloader;
    public Clickinfo.ClickType click;
    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
}

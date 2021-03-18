using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public bool bus = true;
    public List<Vector2> position = new List<Vector2>();
    public NewScene sceneloader;
    public Clickinfo.ClickType click;
    public GameObject talking;
    public GameObject UI;
    public List<int> missions;
    public string previous;
    public List<int> items;
    GameObject agent;
    GameObject background;
    private static GameController _instance;
    private static GameController Instance => _instance;
    void Awake()
    {
        DontDestroyOnLoad(gameObject);
        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            _instance = this;
        }
    }
}

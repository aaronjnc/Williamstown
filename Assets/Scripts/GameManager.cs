using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    [Tooltip("Scene loading with bus")]
    public bool bus = true;
    [Tooltip("List of positions for reloading scenes")]
    public List<Vector2> position = new List<Vector2>();
    [Tooltip("Stores the current new scene class")]
    public NewScene sceneloader;
    [Tooltip("Type of click type")]
    public Clickinfo.ClickType click;
    [Tooltip("Talking game object")]
    public GameObject talking;
    [Tooltip("Player UI")]
    public GameObject UI;
    [Tooltip("List of player missions")]
    public List<int> missions;
    [Tooltip("Name of previous scene")]
    public string previous;
    [Tooltip("List of items")]
    public List<int> items;
    GameObject agent;
    GameObject background;
}

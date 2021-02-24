﻿using System.Collections;
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
    GameObject agent;
    GameObject background;
    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
}

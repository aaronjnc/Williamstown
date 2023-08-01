﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewScene : MonoBehaviour
{
    GameObject player;
    GameManager controller;
    string newscene;
    void Awake()
    {
        controller = GameObject.Find("GameControl").GetComponent<GameManager>();
        player = GameObject.Find("Agent");
    }

    /// <summary>
    /// Set new scene load information
    /// </summary>
    /// <param name="click"></param> Load type
    /// <param name="scene"></param> New scene
    /// <param name="pos"></param> position of clicked item for reloading
    public void LoadType(Clickinfo.ClickType click, string scene, Vector2 pos)
    {
        if (click == Clickinfo.ClickType.Bus)
            controller.bus = true;
        else
            controller.bus = false;
        if (click == Clickinfo.ClickType.Load)
            controller.position.Add(pos);
        newscene = scene;
        controller.click = click;
    }

    /// <summary>
    /// Load new scene
    /// </summary>
    public void LoadScene()
    {
        player.GetComponent<PlayerMovement>().controls.Disable();
        GameObject.Find("Background").GetComponent<ClickAction>().controls.Disable();
        SceneManager.LoadScene(newscene, LoadSceneMode.Single);
    }
}

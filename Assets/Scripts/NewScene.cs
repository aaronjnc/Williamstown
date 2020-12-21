using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewScene : MonoBehaviour
{
    int type = 0;
    //type 0 - bus
    //type 1 - building
    GameObject player;
    GameController controller;
    void Awake()
    {
        controller = GameObject.Find("GameControl").GetComponent<GameController>();
        player = GameObject.Find("Agent");
    }
    public void LoadType(int num, string scene)
    {
        if (type == 0)
            controller.bus = true;
        else
            controller.bus = false;
        controller.position = player.transform.position;
        Debug.Log(controller.bus + " " + controller.position);
        LoadScene(scene);
    }
    public void LoadScene(string scene)
    {
        SceneManager.LoadScene(scene);
    }
}

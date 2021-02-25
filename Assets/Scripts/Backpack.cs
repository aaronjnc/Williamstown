using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Backpack : MonoBehaviour
{
    GameController gamecontrol;
    // Start is called before the first frame update
    void Start()
    {
        GameObject exit = GameObject.Find("Exit");
        gamecontrol = GameObject.Find("GameControl").GetComponent<GameController>();
        exit.name = gamecontrol.previous;
    }
}

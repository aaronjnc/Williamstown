using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneLoad : MonoBehaviour
{
    GameController controller;
    // Start is called before the first frame update
    void Start()
    {
        controller = GameObject.Find("GameControl").GetComponent<GameController>();
        Debug.Log(controller.bus + " " + controller.position);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneLoad : MonoBehaviour
{
    GameController controller;
    GameObject player;
    GameObject vehicle;
    // Start is called before the first frame update
    void Start()
    {
        controller = GameObject.Find("GameControl").GetComponent<GameController>();
        player = GameObject.Find("Agent");
        Debug.Log(controller.bus + " " + controller.position);
        if (controller.bus)
        {
            vehicle = GameObject.Find("Vehicles");
            vehicle.SetActive(true);
        }
        else
        {
            player.transform.position = controller.position;
        }
    }
}

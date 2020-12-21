using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneLoad : MonoBehaviour
{
    GameController controller;
    GameObject player;
    public GameObject vehicle;
    // Start is called before the first frame update
    void Start()
    {
        controller = GameObject.Find("GameControl").GetComponent<GameController>();
        player = GameObject.Find("Agent");
        if (controller.bus)
        {
            player.SetActive(false);
            vehicle.SetActive(true);
        }
        else
        {
            player.transform.position = controller.position;
        }
    }
}

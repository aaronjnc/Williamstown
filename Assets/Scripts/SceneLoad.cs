using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.SceneManagement;

public class SceneLoad : MonoBehaviour
{
    GameManager controller;
    GameObject player;
    public GameObject vehicle;
    
    /// <summary>
    /// Sets up default information based on information in GameManager
    /// </summary>
    void Start()
    {
        player = GameObject.Find("Agent");
        gameObject.GetComponent<ClickAction>().enabled = true;
        if (GameObject.Find("GameControl") != null)
        {
            controller = GameObject.Find("GameControl").GetComponent<GameManager>();
            if (controller.bus)
            {
                player.SetActive(false);
                vehicle.SetActive(true);
            }
            else if (controller.click == Clickinfo.ClickType.Reload)
            {
                Vector3 pos = new Vector3(controller.position.Last().x, player.transform.position.y, player.transform.position.z);
                player.transform.position = pos;
                controller.position.RemoveAt(controller.position.Count - 1);
            }
        }
        if (!controller.bus)
        {
            GameObject.Find("UIObject").GetComponentInChildren<UIClick>().NewScene();
        }
    }
}

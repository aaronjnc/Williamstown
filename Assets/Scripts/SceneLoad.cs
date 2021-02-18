using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.SceneManagement;

public class SceneLoad : MonoBehaviour
{
    GameController controller;
    GameObject player;
    public GameObject vehicle;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Agent");
        if (GameObject.Find("GameControl") != null)
        {
            controller = GameObject.Find("GameControl").GetComponent<GameController>();
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
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIClick : MonoBehaviour, IPointerDownHandler
{
    GameController controller;
    public Sprite journal;
    GameObject agent;
    Transform agentpos;
    private void Awake()
    {
        controller = GameObject.Find("GameControl").GetComponent<GameController>();
        agent = GameObject.Find("Agent");
        agentpos = agent.GetComponent<Transform>();
        DontDestroyOnLoad(gameObject.transform.parent.gameObject);
    }
    void IPointerDownHandler.OnPointerDown(PointerEventData eventData)
    {
        GameObject clicked = eventData.pointerCurrentRaycast.gameObject;
        if (clicked.name.Equals("Journal"))
        {
            clicked.GetComponent<Image>().sprite = journal;
        }
        controller.position.Add(new Vector2(agentpos.position.x, agentpos.position.y));
        controller.previous = SceneManager.GetActiveScene().name;
        agent.GetComponent<PlayerMovement>().controls.Disable();
        GameObject.Find("Background").GetComponent<ClickAction>().controls.Disable();
        SceneManager.LoadScene(eventData.pointerCurrentRaycast.gameObject.name, LoadSceneMode.Single);
    }
}

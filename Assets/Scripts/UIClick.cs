using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIClick : MonoBehaviour, IPointerDownHandler
{
    GameManager controller;
    public Sprite journal;
    GameObject agent;
    Vector2 agentpos;
    private static UIClick _instance;
    private static UIClick Instance => _instance;
    void Start()
    {
        DontDestroyOnLoad(gameObject.transform.parent.gameObject);
    }
    private void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject.transform.parent.gameObject);
        }
        else
        {
            _instance = this;
        }
    }
    void IPointerDownHandler.OnPointerDown(PointerEventData eventData)
    {
        GameObject clicked = eventData.pointerCurrentRaycast.gameObject;
        if (clicked.name.Equals("Journal"))
        {
            clicked.GetComponent<Image>().sprite = journal;
        }
        agentpos = agent.transform.position;
        controller.position.Add(agentpos);
        controller.previous = SceneManager.GetActiveScene().name;
        agent.GetComponent<PlayerMovement>().controls.Disable();
        GameObject.Find("Background").GetComponent<ClickAction>().controls.Disable();
        SceneManager.LoadScene(eventData.pointerCurrentRaycast.gameObject.name, LoadSceneMode.Single);
    }
    public void NewScene()
    {
        controller = GameObject.Find("GameControl").GetComponent<GameManager>();
        agent = GameObject.FindGameObjectWithTag("Player");
        agentpos = agent.transform.position;
    }
}

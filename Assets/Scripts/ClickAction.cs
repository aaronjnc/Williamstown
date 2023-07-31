using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using static UnityEngine.InputSystem.InputAction;

public class ClickAction : MonoBehaviour
{
    public PlayerControls controls;
    WalktoLoc player;
    GameObject playerobj;
    PlayerMovement playermove;
    public bool canclick = true;
    void Start()
    {
        controls = new PlayerControls();
        controls.BaseActions.Click.performed += OnClick;
        controls.BaseActions.Enable();
    }
    void OnClick(CallbackContext ctx)
    {
        if (canclick)
        {
            Vector2 mousepos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
            RaycastHit2D hit = Physics2D.Raycast(mousepos, Vector2.zero);
            if (hit && hit.transform.gameObject.CompareTag("clickable"))
            {
                playerobj = GameObject.Find("Agent");
                playermove = playerobj.GetComponent<PlayerMovement>();
                playermove.controls.Disable();
                GameObject clicked = hit.transform.gameObject;
                Clickinfo info = clicked.GetComponent<Clickinfo>();
                if (info.click != Clickinfo.ClickType.Item && info.click != Clickinfo.ClickType.Talk)
                {
                    NewScene(clicked);
                }
                WalktoLoc(clicked, info);
            }
        }
    }
    void WalktoLoc(GameObject clicked, Clickinfo info)
    {
        player = playerobj.GetComponent<WalktoLoc>();
        player.type = info.click;
        if (player.type.Equals(Clickinfo.ClickType.Talk))
        {
            playerobj.GetComponent<Dialog>().Activate(clicked);
            GameObject.Find("GameControl").GetComponent<GameManager>().talking = clicked;
            float relloc = playerobj.transform.position.x - clicked.transform.position.x;
            if (relloc > 0)
            {
                player.loc = clicked.transform.position.x + 1.5f;
            }
            else
            {
                player.loc = clicked.transform.position.x - 1.5f;
            }
        }
        else
        {
            player.loc = clicked.transform.position.x;
            player.item =clicked;
        }
        player.enabled = true;
    }
    void NewScene(GameObject clicked)
    {
        NewScene load = gameObject.AddComponent<NewScene>();
        load.LoadType(clicked.GetComponent<Clickinfo>().click, clicked.name,clicked.transform.position);
        GameObject.Find("GameControl").GetComponent<GameManager>().sceneloader = load;
    }

    private void OnDestroy()
    {
        controls.BaseActions.Disable();
    }
}

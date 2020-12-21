using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using static UnityEngine.InputSystem.InputAction;

public class ClickAction : MonoBehaviour
{
    PlayerControls controls;
    WalktoLoc player;
    void Awake()
    {
        controls = new PlayerControls();
        controls.BaseActions.Click.performed += OnClick;
        controls.BaseActions.Enable();
    }
    public int loadtype;
    void OnClick(CallbackContext ctx)
    {
        Vector3 mousepos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        Vector2 min = GetComponent<Collider2D>().bounds.min;
        Vector2 max = GetComponent<Collider2D>().bounds.max;
        if (mousepos.x > min.x && mousepos.x < max.x && mousepos.y > min.y && mousepos.y < max.y)
        {
            if (loadtype < 2)
            {
                NewScene();
            }
            player = GameObject.Find("Agent").GetComponent<WalktoLoc>();
            player.type = loadtype;
            player.loc = gameObject.transform.position.x;
            player.enabled = true;
        }
    }
    void NewScene()
    {
        NewScene load = gameObject.AddComponent<NewScene>();
        load.LoadType(loadtype, gameObject.name);
        GameObject.Find("GameControl").GetComponent<GameController>().sceneloader = load;
    }
}

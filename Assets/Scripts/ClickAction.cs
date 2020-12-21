using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using static UnityEngine.InputSystem.InputAction;

public class ClickAction : MonoBehaviour
{
    PlayerControls controls;

    void Awake()
    {
        controls = new PlayerControls();
        controls.BaseActions.Click.performed += OnClick;
        controls.BaseActions.Enable();
    }
    public int loadtype;
    void OnClick(CallbackContext ctx)
    {
        Ray ray = Camera.main.ScreenPointToRay(Mouse.current.position.ReadValue());
        RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction, 10f);
        if (hit && hit.transform.gameObject.CompareTag("clickable"))
        {
            NewScene();
        }
    }
    void NewScene()
    {
        NewScene load = gameObject.AddComponent<NewScene>();
        load.LoadType(loadtype, gameObject.name);
    }
}

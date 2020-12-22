using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using static UnityEngine.InputSystem.InputAction;
using UnityEngine.SceneManagement;

public class MapClick : MonoBehaviour
{
    PlayerControls control;
    GameController controller;
    // Start is called before the first frame update
    void Start()
    {
        controller = GameObject.Find("GameControl").GetComponent<GameController>();
        control = new PlayerControls();
        control.BaseActions.Click.performed += OnClick;
        control.BaseActions.Click.Enable();
    }
    void OnClick(CallbackContext ctx)
    {
        Vector2 mousepos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        RaycastHit2D hit = Physics2D.Raycast(mousepos, Vector2.zero);
        if (hit && hit.transform.gameObject.name != "Background")
        {
            NewScene(hit.transform.gameObject.name);
        }
    }
    void NewScene(string name)
    {
        controller.bus = true;
        controller.position.Clear();
        control.Disable();
        SceneManager.LoadScene(name);
    }
}

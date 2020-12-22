using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.InputSystem.InputAction;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D player;
    public PlayerControls controls;
    Vector2 direction;
    public float speed = 5f;
    public RuntimeAnimatorController left;
    public RuntimeAnimatorController right;
    Sprite sprite;
    // Start is called before the first frame update
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>().sprite;
        player = GetComponent<Rigidbody2D>();
        //controls = GameObject.Find("GameControl").GetComponent<GameController>().control;
        controls = new PlayerControls();
        controls.BaseActions.PlayerMovement.performed += OnMove;
        controls.BaseActions.PlayerMovement.canceled += Stop;
        controls.BaseActions.PlayerMovement.Enable();
    }
    void OnMove(CallbackContext ctx)
    {
        GetComponent<Animator>().enabled = true;
        direction = ctx.ReadValue<Vector2>();
        if (direction[0]<1)
        {
            GetComponent<Animator>().runtimeAnimatorController = left;
        }
        else
            GetComponent<Animator>().runtimeAnimatorController = right;
    }
    void Stop(CallbackContext ctx)
    {
        direction = new Vector2(0, 0);
        GetComponent<Animator>().runtimeAnimatorController = null;
        GetComponent<Animator>().enabled = false;
        GetComponent<SpriteRenderer>().sprite = sprite;
    }
    // Update is called once per frame
    void Update()
    {
        player.position += direction*speed*Time.deltaTime;
    }
}

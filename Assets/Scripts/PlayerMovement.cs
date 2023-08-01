using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.InputSystem.InputAction;

public class PlayerMovement : MonoBehaviour
{
    [Tooltip("Player rigidbody")]
    Rigidbody2D player;
    [Tooltip("Player controls")]
    public PlayerControls controls;
    [Tooltip("Movement direction")]
    Vector2 direction;
    [Tooltip("Player movement speed")]
    public float speed = 5f;
    [Tooltip("Left walk animation")]
    public RuntimeAnimatorController left;
    [Tooltip("Right walk animation")]
    public RuntimeAnimatorController right;
    [Tooltip("Player sprite")]
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
    void Update()
    {
        player.position += direction * speed * Time.deltaTime;
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
}

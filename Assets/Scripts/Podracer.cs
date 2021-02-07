using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Podracer : MonoBehaviour
{
    public float health = 3.0f;
    public float maxspeed = 4f;
    Rigidbody2D player;
    public float speed = 4f;
    Vector2 direction;
    float friction = 1f;
    PlayerControls controls;
    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Rigidbody2D>();
        controls = new PlayerControls();
        controls.Podracer.Movement.performed += ctx => direction = ctx.ReadValue<Vector2>();
        controls.Podracer.Movement.canceled += ctx => direction = Vector2.zero;
        controls.Podracer.Movement.Enable();
    }

    // Update is called once per frame
    void LateUpdate()
    {
        player.velocity += direction * speed * Time.deltaTime;
        if (Mathf.Abs(player.velocity.magnitude) > maxspeed)
        {
            player.velocity = player.velocity.normalized * maxspeed;
        }
        if (player.velocity.magnitude != 0)
        {
            player.velocity = player.velocity.normalized * (player.velocity.magnitude - friction*Time.deltaTime);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!collision.gameObject.layer.Equals(8))
        {
            health--;
            if (health == 0)
            {
                Debug.Log("Destroyed");
            }
        }
    }
}

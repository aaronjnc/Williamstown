using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PodraceScroll : MonoBehaviour
{
    Rigidbody2D background;
    public float speed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        background = GetComponent<Rigidbody2D>();
        background.velocity = new Vector2(0, -speed);
    }
}

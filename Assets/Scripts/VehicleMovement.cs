using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleMovement : MonoBehaviour
{
    public GameObject agent;
    Rigidbody2D vehicle;
    SpriteRenderer vehiclerenderer;
    public float speed = 5f;
    bool movable = true;
    public Sprite charvehicle;
    public Sprite emptyvehicle;
    bool empty = false;
    float bounds;
    Vector2 startpos;
    void Start()
    {
        startpos = transform.position;
        vehicle = GetComponent<Rigidbody2D>();
        vehiclerenderer = GetComponent<SpriteRenderer>();
        bounds = GameObject.Find("Background").GetComponent<Collider2D>().bounds.extents.x;
    }
    void Update()
    {
        if (movable && vehicle.position.x < bounds)
        {
            vehicle.position += new Vector2(1, 0) * speed * Time.deltaTime;
        }
        else if (vehicle.position.x >= bounds)
        {
            OffScreen();
        }
    }
    void OffScreen()
    {
        if (!empty)
        {
            GameObject.Find("GameControl").GetComponent<GameController>().sceneloader.LoadScene();
        }
        else
        {
            transform.position = startpos;
            GameObject.Find("Vehicles").SetActive(false);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.gameObject.name == "VehicleStop")
        {
            movable = false;
            if (!empty)
            {
                agent.SetActive(true);
                vehiclerenderer.sprite = emptyvehicle;
            }
            else
            {
                agent.SetActive(false);
                vehiclerenderer.sprite = charvehicle;
            }
            empty = !empty;
            movable = true;
        }
    }
}

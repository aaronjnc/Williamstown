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
    Vector2 size;
    void Start()
    {
        startpos = transform.position;
        vehicle = GetComponent<Rigidbody2D>();
        vehiclerenderer = GetComponent<SpriteRenderer>();
        bounds = GameObject.Find("Background").GetComponent<Collider2D>().bounds.extents.x;
        size = vehiclerenderer.bounds.size;
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
    IEnumerator wait()
    {
        yield return new WaitForSeconds(1f);
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
        NewScale();
        empty = !empty;
        movable = true;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.gameObject.name == "VehicleStop")
        {
            movable = false;
            collision.transform.gameObject.SetActive(false);
            StartCoroutine("wait");
        }
    }
    void NewScale()
    {
        float sizex = vehiclerenderer.bounds.size.x;
        float sizey = vehiclerenderer.bounds.size.y;
        Vector3 rescale = transform.localScale;
        rescale.x = size.x * rescale.x / sizex;
        rescale.y = size.y * rescale.y / sizey;
        transform.localScale = rescale;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class VehicleMovement : MonoBehaviour
{
    public GameObject agent;
    Rigidbody2D vehicle;
    SpriteRenderer vehiclerenderer;
    GameObject stop;
    public Vector2 startdir = new Vector2(1,0);
    public Vector2 enddir = new Vector2(1, 0);
    public float speed = 5f;
    bool movable = true;
    public Sprite charvehicle;
    public Sprite emptyvehicle;
    bool empty = false;
    Vector2 bounds;
    Vector3 startpos;
    Vector2 size;
    bool done = false;
    private void Awake()
    {
        startpos = transform.position;
        vehicle = GetComponent<Rigidbody2D>();
        vehiclerenderer = GetComponent<SpriteRenderer>();
        size = vehiclerenderer.bounds.size;
        stop = GameObject.Find("VehicleStop");
        bounds = GameObject.Find("Background").GetComponent<Collider2D>().bounds.extents;
    }

    void Update()
    {
        if (movable && ((vehicle.position.x < bounds.x && vehicle.position.y < bounds.y) || !done))
        {
            if (done)
                vehicle.position += enddir * speed * Time.deltaTime;
            else
                vehicle.position += startdir* speed * Time.deltaTime;
        }
        else if (done && (vehicle.position.x >= bounds.x || vehicle.position.y >= bounds.y))
        {
            stop.SetActive(true);
            OffScreen();
        }
    }
    void OffScreen()
    {
        if (!empty)
        {
            GameObject.Find("GameControl").GetComponent<GameManager>().sceneloader.LoadScene();
        }
        else
        {
            transform.position = startpos;
            if (startdir.x != enddir.x)
            {
                vehiclerenderer.flipX = !vehiclerenderer.flipX;
            }
            GameObject.Find("Vehicles").SetActive(false);
        }
    }
    IEnumerator wait()
    {
        yield return new WaitForSeconds(1f);
        if (!empty)
        {
            agent.SetActive(true);
            GameObject.Find("UIObject").GetComponentInChildren<UIClick>().NewScene();
            vehiclerenderer.sprite = emptyvehicle;
        }
        else
        {
            agent.SetActive(false);
            vehiclerenderer.sprite = charvehicle;
        }
        done = true;
        NewScale();
        empty = !empty;
        movable = true;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.gameObject.name.Equals("VehicleStop"))
        {
            movable = false;
            collision.transform.gameObject.SetActive(false);
            //collision.transform.gameObject.SetActive(false);
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
        if (startdir.x != enddir.x)
        {
            vehiclerenderer.flipX = !vehiclerenderer.flipX;
        }
    }
    public void Reload()
    {
        vehiclerenderer.sprite = emptyvehicle;
        NewScale();
        empty = true;
    }
}

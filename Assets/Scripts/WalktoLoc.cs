using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalktoLoc : MonoBehaviour
{
    [Tooltip("Player speed")]
    float speed;
    [Tooltip("X location to walk to")]
    public float loc;
    [Tooltip("Movement direction")]
    Vector2 dir = new Vector2(0,0);
    [Tooltip("Right walk animation")]
    RuntimeAnimatorController right;
    [Tooltip("Left walk animation")]
    RuntimeAnimatorController left;
    Rigidbody2D player;
    [Tooltip("Vehicles to enable if walking to bus stop")]
    public GameObject vehicles;
    [Tooltip("Type of location walking to")]
    public Clickinfo.ClickType type;
    [Tooltip("True if looking right")]
    bool lookR = false;
    [Tooltip("Player sprite")]
    Sprite sprite;
    [Tooltip("NPC talking bubble")]
    public Object NPCTalk;
    [Tooltip("Player talking bubble")]
    public Object PlayerTalk;
    [Tooltip("True once player has reached location")]
    bool stopped = false;
    [Tooltip("Item to pickup if walking to item")]
    public GameObject item;
    GameManager controller;
    private void OnEnable()
    {
        controller = GameObject.Find("GameControl").GetComponent<GameManager>();
        sprite = GetComponent<SpriteRenderer>().sprite;
        player = GetComponent<Rigidbody2D>();
        PlayerMovement movement = gameObject.GetComponent<PlayerMovement>();
        speed = movement.speed;
        right = movement.right;
        left = movement.left;
        Direction();
    }

    /// <summary>
    /// Determine direction to walk and orients player animation
    /// </summary>
    void Direction()
    {
        GetComponent<Animator>().enabled = true;
        if (loc > transform.position.x)
        {
            dir = new Vector2(1, 0);
            GetComponent<Animator>().runtimeAnimatorController = right;
            lookR = true;
        }
        else
        {
            dir = new Vector2(-1, 0);
            GetComponent<Animator>().runtimeAnimatorController = left;
            lookR = false;
        }
    }

    /// <summary>
    /// Called each frame, moves player torwards destination
    /// </summary>
    private void Update()
    {
        if ((lookR && transform.position.x < loc) || (!lookR && transform.position.x > loc))
        {
            player.position += dir * speed * Time.deltaTime;
        }
        else if (!stopped)
        {
            stopped = true;
            Action();
        }
    }

    /// <summary>
    /// Determines what action to perform upon arriving at destination
    /// </summary>
    void Action()
    {
        this.enabled = false;
        stopped = false;
        GetComponent<Animator>().enabled = false;
        GetComponent<SpriteRenderer>().sprite = sprite;
        switch(type)
        {
            case Clickinfo.ClickType.Bus:
                vehicles.SetActive(true);
                vehicles.GetComponentInChildren<VehicleMovement>().Reload();
                break;
            case Clickinfo.ClickType.Load:
                controller.sceneloader.LoadScene();
                break;
            case Clickinfo.ClickType.Reload:
                controller.sceneloader.LoadScene();
                break;
            case Clickinfo.ClickType.Talk:
                Talk();
                break;
            case Clickinfo.ClickType.Item:
                Item();
                break;
        }
    }

    /// <summary>
    /// Used when walking to talking location
    /// </summary>
    void Talk()
    {
        Instantiate(PlayerTalk);
        gameObject.GetComponent<PlayerMovement>().enabled = false;
        GameObject.Find("Background").GetComponent<ClickAction>().canclick = false;
    }

    /// <summary>
    /// Used when walking to pick up an item
    /// </summary>
    void Item()
    {
        Destroy(item);
        controller.items.Add(item.GetComponent<ItemInfo>().itemnum);
    }
}

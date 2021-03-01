using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalktoLoc : MonoBehaviour
{
    float speed;
    public float loc;
    Vector2 dir = new Vector2(0,0);
    RuntimeAnimatorController right;
    RuntimeAnimatorController left;
    Rigidbody2D player;
    public GameObject vehicles;
    public Clickinfo.ClickType type;
    bool lookR = false;
    Sprite sprite;
    public Object NPCTalk;
    public Object PlayerTalk;
    bool stopped = false;
    public GameObject item;
    GameController controller;
    private void OnEnable()
    {
        controller = GameObject.Find("GameControl").GetComponent<GameController>();
        sprite = GetComponent<SpriteRenderer>().sprite;
        player = GetComponent<Rigidbody2D>();
        PlayerMovement movement = gameObject.GetComponent<PlayerMovement>();
        speed = movement.speed;
        right = movement.right;
        left = movement.left;
        Direction();
    }
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
    void Talk()
    {
        Instantiate(PlayerTalk);
        gameObject.GetComponent<PlayerMovement>().enabled = false;
        GameObject.Find("Background").GetComponent<ClickAction>().canclick = false;
    }
    void Item()
    {
        Destroy(item);
        controller.items.Add(item.GetComponent<ItemInfo>().itemnum);
    }
}

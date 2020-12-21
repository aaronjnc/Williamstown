using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.Animations;

public class WalktoLoc : MonoBehaviour
{
    float speed;
    public float loc;
    Vector2 dir = new Vector2(0,0);
    AnimatorController right;
    AnimatorController left;
    Rigidbody2D player;
    public GameObject vehicles;
    public int type;
    bool lookR = false;
    Sprite sprite;
    private void OnEnable()
    {
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
        else
        {
            Action();
        }
    }
    void Action()
    {
        GetComponent<Animator>().enabled = false;
        GetComponent<SpriteRenderer>().sprite = sprite;
        switch(type)
        {
            case 0:
                vehicles.SetActive(true);
                break;
            case 1:
                GameObject.Find("GameControl").GetComponent<GameController>().sceneloader.LoadScene();
                break;
        }
    }
}

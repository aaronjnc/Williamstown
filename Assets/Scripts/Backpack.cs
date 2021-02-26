using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Backpack : MonoBehaviour
{
    GameController gamecontrol;
    Sprite[] items;
    public GameObject box;
    List<GameObject> boxes;
    float xpos = -7.3f;
    float ypos = 2.7f;
    float ydif = .7f;
    float xdif = 3.3f;
    // Start is called before the first frame update
    void Start()
    {
        GameObject exit = GameObject.Find("Exit");
        gamecontrol = GameObject.Find("GameControl").GetComponent<GameController>();
        exit.name = gamecontrol.previous;
        items = (Sprite[])Resources.LoadAll("Items",typeof(Sprite));
        for (int i = 0; i < gamecontrol.items.Count;i++)
        {
            CreateBox(gamecontrol.items[i]);
        }
    }
    void CreateBox(int i)
    {
        int current = boxes.Count - 1;
        boxes.Add(Instantiate(box));
        float x = xpos + xdif * (current % 6);
        float y = ypos - ydif * (int)((boxes.Count - 1) / 6);
        boxes[current].transform.position = new Vector2(x, y);
        boxes[current].GetComponent<SpriteRenderer>().sprite = items[i];
    }
}

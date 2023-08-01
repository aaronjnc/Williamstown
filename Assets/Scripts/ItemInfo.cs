using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemInfo : MonoBehaviour
{
    public int itemnum = 0;
    private void Start()
    {
        GameManager controller = GameObject.Find("GameControl").GetComponent<GameManager>();
        if (controller.items.Contains(itemnum))
        {
            Destroy(gameObject);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorderLoad : MonoBehaviour
{
    public Clickinfo.ClickType loadtype;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.gameObject.name.Equals("Agent"))
        {
            NewScene newScene = gameObject.AddComponent<NewScene>();
            newScene.LoadType(loadtype, gameObject.name, collision.transform.position);
            newScene.LoadScene();
        }
    }
}

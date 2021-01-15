using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.InputSystem.InputAction;

public class BorderLoad : MonoBehaviour
{
    public Clickinfo.ClickType loadtype;
    public bool left = false;
    PlayerControls controls;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.gameObject.name.Equals("Agent"))
        {
            Vector2 pos = collision.transform.position;
            if (left)
                pos.x += 1;
            else
                pos.x -= 1;
            NewScene newScene = gameObject.AddComponent<NewScene>();
            newScene.LoadType(loadtype, gameObject.name, pos);
            newScene.LoadScene();
        }
    }
}

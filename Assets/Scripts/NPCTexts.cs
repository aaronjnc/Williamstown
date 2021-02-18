using System.Collections;
using System.Collections.Generic;
using System.IO;
using TMPro;
using UnityEngine;
using static UnityEngine.InputSystem.InputAction;

public class NPCTexts : MonoBehaviour
{
    public Object PlayerText;
    PlayerControls controls;
    Vector2 picsize;
    GameObject head;
    GameObject talking;
    TextAsset npcdialog;
    TextMeshPro textbox;
    Dialog dialog;
    List<int> rows = new List<int>();
    // Start is called before the first frame update
    void Start()
    {
        dialog = GameObject.Find("Agent").GetComponent<Dialog>();
        controls = new PlayerControls();
        controls.TextControls.Accelerate.performed += Accelerate;
        controls.TextControls.Accelerate.Enable();
        head = GameObject.Find("NPCHead");
        picsize = head.GetComponent<SpriteRenderer>().bounds.size;
        talking = GameObject.Find("GameControl").GetComponent<GameController>().talking;
        NPCScript npcscript = talking.GetComponent<NPCScript>();
        head.GetComponent<SpriteRenderer>().sprite = npcscript.headshot;
        textbox = GameObject.Find("NPCText").GetComponent<TextMeshPro>();
        GameObject.Find("NPCNameText").GetComponent<TextMeshPro>().text = talking.name;
        Resize();
    }
    void Accelerate(CallbackContext ctx)
    {
        dialog.UpdateRow(dialog.current);
        Instantiate(PlayerText);
        Destroy(gameObject);
        //Select
    }
    void Resize()
    {
        Vector2 newsize = head.GetComponent<SpriteRenderer>().bounds.size;
        Vector3 rescale = head.transform.localScale;
        rescale.x = picsize.x * rescale.x / newsize.x;
        rescale.y = picsize.y * rescale.y / newsize.y;
        head.transform.localScale = rescale;
    }
    void UpdateText()
    {
        rows = dialog.group();
        textbox.text = dialog.texts[rows[0], 2];
    }
}

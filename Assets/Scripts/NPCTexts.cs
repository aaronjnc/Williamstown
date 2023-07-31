using System.Collections;
using System.Collections.Generic;
using System.IO;
using TMPro;
using UnityEngine;
using static UnityEngine.InputSystem.InputAction;

public class NPCTexts : MonoBehaviour
{
    GameObject player;
    public Object PlayerText;
    PlayerControls controls;
    Vector2 picsize;
    SpriteRenderer head;
    TextAsset npcdialog;
    TextMeshPro textbox;
    Dialog dialog;
    List<int> rows = new List<int>();
    List<GameObject> talking = new List<GameObject>();
    TextMeshPro name;
    List<NPCScript> npcscripts = new List<NPCScript>();
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Agent");
        dialog = player.GetComponent<Dialog>();
        controls = new PlayerControls();
        controls.TextControls.Accelerate.performed += Accelerate;
        controls.TextControls.Accelerate.Enable();
        head = GameObject.Find("NPCHead").GetComponent<SpriteRenderer>();
        picsize = head.bounds.size;
        GameObject gamecontrol = GameObject.Find("GameControl");
        talking.Add(gamecontrol.GetComponent<GameManager>().talking);
        npcscripts.Add(talking[0].GetComponent<NPCScript>());
        if (npcscripts[0].othernpc != null)
        {
            talking.Add(npcscripts[0].othernpc);
            npcscripts.Add(talking[1].GetComponent<NPCScript>());
        }
        head.sprite = npcscripts[0].headshot;
        textbox = GameObject.Find("NPCText").GetComponent<TextMeshPro>();
        UpdateText();
        name = GameObject.Find("NPCNameText").GetComponent<TextMeshPro>();
        name.text = talking[0].name;
        Resize();
    }
    void Accelerate(CallbackContext ctx)
    {
        bool dashed = dialog.UpdateRow(rows[0]);
        int character = dialog.Character(dialog.group());
        if (!dashed)
        {
            if (character.Equals(0))
            {
                controls.Disable();
                Instantiate(PlayerText);
                Destroy(gameObject);
            }
            else
            {
                UpdateName(character-1);
                UpdateText();
            }
        }
        else
        {
            controls.Disable();
            player.GetComponent<PlayerMovement>().enabled = true;
            player.GetComponent<PlayerMovement>().controls.Enable();
            Destroy(gameObject);
        }
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
    void UpdateName(int i)
    {
        name.text = talking[i].name;
        head.sprite = npcscripts[i].headshot;
        Resize();
    }
}

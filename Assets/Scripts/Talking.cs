using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using static UnityEngine.InputSystem.InputAction;

public class Talking : MonoBehaviour
{
    PlayerControls controls;
    GameObject[] texts = new GameObject[3];
    int highlighted = 0;
    Color basecolor;
    Color highlightcolor;
    public Object NPCText;
    // Start is called before the first frame update
    void Start()
    {
        controls = new PlayerControls();
        texts[0] = GameObject.Find("Text1");
        texts[1] = GameObject.Find("Text2");
        texts[2] = GameObject.Find("Text3");
        basecolor = texts[0].GetComponent<TextMeshPro>().color;
        highlightcolor = new Color(139, 0, 0);
        controls.TextControls.Switch.performed += Switch;
        controls.TextControls.Switch.Enable();
        controls.TextControls.Accelerate.performed += Accelerate;
        controls.TextControls.Accelerate.Enable();
        texts[0].GetComponent<TextMeshPro>().color = highlightcolor;
    }
    void Switch(CallbackContext ctx)
    {
        texts[highlighted].GetComponent<TextMeshPro>().color = basecolor;
        highlighted = Mathf.Clamp(highlighted + (int)ctx.ReadValue<float>(), 0, 2);
        texts[highlighted].GetComponent<TextMeshPro>().color = highlightcolor;
    }
    void Accelerate(CallbackContext ctx)
    {
        Instantiate(NPCText);
        Destroy(gameObject);
        //Select
    }
}

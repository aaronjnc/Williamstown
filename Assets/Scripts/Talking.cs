﻿using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using static UnityEngine.InputSystem.InputAction;

public class Talking : MonoBehaviour
{
    GameObject player;
    PlayerControls controls;
    TextMeshPro[] texts = new TextMeshPro[3];
    int highlighted = 0;
    Color basecolor;
    Color highlightcolor;
    public Object NPCText;
    int max = 2;
    Dialog dialog;
    List<int> rows = new List<int>();
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Agent");
        dialog = player.GetComponent<Dialog>();
        controls = new PlayerControls();
        texts[0] = GameObject.Find("Text1").GetComponent<TextMeshPro>();
        texts[1] = GameObject.Find("Text2").GetComponent<TextMeshPro>(); ;
        texts[2] = GameObject.Find("Text3").GetComponent<TextMeshPro>(); ;
        basecolor = texts[0].GetComponent<TextMeshPro>().color;
        highlightcolor = new Color(139, 0, 0);
        controls.TextControls.Switch.performed += Switch;
        controls.TextControls.Switch.Enable();
        controls.TextControls.Accelerate.performed += Accelerate;
        controls.TextControls.Accelerate.Enable();
        UpdateText();
        texts[0].color = highlightcolor;
    }
    void Switch(CallbackContext ctx)
    {
        texts[highlighted].color = basecolor;
        highlighted = Mathf.Clamp(highlighted + (int)ctx.ReadValue<float>(), 0, max);
        texts[highlighted].color = highlightcolor;
    }
    void Accelerate(CallbackContext ctx)
    {
        bool dashed = dialog.UpdateRow(rows[highlighted]);
        Debug.Log(dialog.current);
        controls.Disable();
        if (!dashed)
        {
            Instantiate(NPCText);
            Destroy(gameObject);
        }
        else
        {
            player.GetComponent<PlayerMovement>().controls.Enable();
            Destroy(gameObject);
        }
        //Select
    }
    void UpdateText()
    {
        rows = dialog.group();
        max = rows.Count;
        for (int i = 0; i < max; i++)
        {
            texts[i].text = dialog.texts[i, 2];
        }
        for (int i = max; i < 3; i++)
        {
            texts[i].text = "";
        }
    }
}
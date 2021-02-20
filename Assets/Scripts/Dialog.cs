using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class Dialog : MonoBehaviour
{
    TextAsset dialog;
    public string[,] texts;
    public int current;
    int count;
    public bool UpdateRow(int num)
    {
        if (!char.IsNumber(texts[num, 3][0]))
        {
            return true;
        }
        current = int.Parse(texts[num, 3]);
        return false;
    }
    public void Activate(GameObject character)
    {
        dialog = character.GetComponent<NPCScript>().npcdialog;
        string[] dialogs = dialog.text.Split('\n');
        count = dialogs.Length;
        texts = new string[count, 4];
        for (int i = 0; i < count; i++)
        {
            string[] split = dialogs[i].Split('|');
            texts[i, 0] = split[0];
            texts[i, 1] = split[1];
            texts[i, 2] = split[2];
            texts[i, 3] = split[3];
        }
    }
    
    public List<int> group()
    {
        List<int> rows = new List<int>();
        int i = 0;
        while (i < count && int.Parse(texts[i,0]) <= current)
        {
            if (int.Parse(texts[i,0]) == current)
            {
                rows.Add(i);
            }
            i++;
        }
        return rows;
    }
}

using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class Dialog : MonoBehaviour
{
    TextAsset dialog;
    public string[,] texts;
    public int current;
    int count;
    public Sprite journalnotif;
    Image journal;
    GameController controller;
    private void Awake()
    {
        journal = GameObject.Find("Journal").GetComponent<Image>();
        controller = GameObject.Find("GameControl").GetComponent<GameController>();
    }
    public bool UpdateRow(int num)
    {
        NewMission(num);
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
        texts = new string[count, 5];
        for (int i = 0; i < count; i++)
        {
            string[] split = dialogs[i].Split('|');
            for (int j = 0; j < split.Length;j++)
            {
                texts[i, j] = split[j];
            }
        }
    }
    void NewMission(int num)
    {
        if (!int.Parse(texts[num,4]).Equals(0))
        {
            journal.sprite = journalnotif;
            controller.missions.Add(int.Parse(texts[num, 4]) - 1);
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
    public int Character(List<int> rows)
    {
        return int.Parse(texts[rows[0],1]);
    }
}

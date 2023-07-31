using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Journal : MonoBehaviour
{
    public TextAsset mission;
    public GameObject missionlines;
    List<string> missions = new List<string>();
    GameManager gamecontrol;
    List<GameObject> lines = new List<GameObject>();
    public float xpos = -6.17f;
    public float ypos = 3.87f;
    public float ydif = .6f;
    void Start()
    {
        GameObject exit = GameObject.Find("Exit");
        gamecontrol = GameObject.Find("GameControl").GetComponent<GameManager>();
        exit.name = gamecontrol.previous;
        string[] texts = mission.text.Split('\n');
        missions = new List<string>(texts);
        for(int i = 0; i < gamecontrol.missions.Count;i++)
        {
            CreateLine(gamecontrol.missions[i]);
        }
    }
    void CreateLine(int i)
    {
        lines.Add(Instantiate(missionlines));
        float y = ypos - ydif * (lines.Count - 1);
        lines[lines.Count-1].transform.position = new Vector2(xpos, y);
        lines[lines.Count-1].GetComponent<TextMesh>().text = missions[i];
    }
}

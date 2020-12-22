using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clickinfo : MonoBehaviour
{
    public enum ClickType
    {
        Bus,
        Load,
        Reload,
        Item,
        Talk
    }
    public ClickType click;
}

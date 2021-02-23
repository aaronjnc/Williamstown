using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIClick : MonoBehaviour, IPointerDownHandler
{
    public Sprite journal;
    private void Awake()
    {
        DontDestroyOnLoad(gameObject.transform.parent.gameObject);
    }
    void IPointerDownHandler.OnPointerDown(PointerEventData eventData)
    {
        GameObject clicked = eventData.pointerCurrentRaycast.gameObject;
        if (clicked.name.Equals("Journal"))
        {
            clicked.GetComponent<Image>().sprite = journal;
        }
        SceneManager.LoadScene(eventData.pointerCurrentRaycast.gameObject.name, LoadSceneMode.Single);
    }
}

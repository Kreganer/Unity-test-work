using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ClickCube : MonoBehaviour, IPointerClickHandler {

    public static bool ClickMenu = false;
    public GameObject ClickMUI;

    public void OnPointerClick(PointerEventData eventData)
    {
        if (eventData.pointerId == -2)
        {
            ClickMUI.SetActive(true);
            ClickMenu = true;
        }
        else 
        {
            ClickMUI.SetActive(false);
            ClickMenu = false;
        }
    }
}

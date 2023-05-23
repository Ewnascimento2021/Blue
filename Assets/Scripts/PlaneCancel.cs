using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneCancel : MonoBehaviour
{
    private bool mouseEnter;
    void Update()
    {
        if (mouseEnter && Input.GetMouseButtonDown(0))
        {
            ReferenceController.Instance.CancelSelected = true;
        }
    }

    private void OnMouseEnter()
    {
        mouseEnter = true;
    }

    private void OnMouseExit()
    {
        mouseEnter = false;
    }
}

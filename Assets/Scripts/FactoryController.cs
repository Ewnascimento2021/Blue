using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class FactoryController : MonoBehaviour
{
    [SerializeField]
    private int myFactoryNumber;

    private bool mouseEnter;
    private bool iAmSelected;


    void Update()
    {
        if (iAmSelected && !mouseEnter && Input.GetMouseButtonDown(0))
        {
            iAmSelected = false;
            gameObject.GetComponent<Outline>().enabled = false;
        }
        if (mouseEnter && Input.GetMouseButtonDown(0))
        {
            ReferenceController.Instance.factorySelected = myFactoryNumber;
            iAmSelected = true;
            PaintSelectFactory();
        }
    }

    private void PaintSelectFactory()
    {
        gameObject.GetComponent<Outline>().enabled = true;
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

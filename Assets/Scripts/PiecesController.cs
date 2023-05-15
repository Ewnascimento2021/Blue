using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PiecesController : MonoBehaviour
{
    private Collider m_Collider;
    private bool mouseEnter;
    private bool iAmSelected;
    public string myName;


    void Start()
    {
        m_Collider = GetComponent<Collider>();
        m_Collider.enabled = false;
    }

    void Update()
    {
        if (ReferenceController.Instance.factorySelected == 1 && myName == "Fab1")
        {
            m_Collider.enabled = true;
        }
        if (Input.GetMouseButtonDown(0) && m_Collider == true)
        {
            if (iAmSelected && !mouseEnter)
            {
                iAmSelected = false;
                gameObject.GetComponent<Outline>().enabled = false;
                m_Collider.enabled = false;
            }
            if (mouseEnter)
            {
                PaintSelectFactory();
                iAmSelected = true;
            }
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

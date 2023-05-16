using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PiecesController : MonoBehaviour
{
    private Collider m_Collider;
    private bool mouseEnter;
    private bool iAmSelected;
    public string factoryName;


    void Start()
    {
        m_Collider = GetComponent<Collider>();
        m_Collider.enabled = false;
    }

    void Update()
    {
        if (ReferenceController.Instance.factoryName == factoryName)
        {
            m_Collider.enabled = true;

            if (Input.GetMouseButtonDown(0))
            {
                if (iAmSelected && !mouseEnter)
                {
                    ReferenceController.Instance.pieceSelected = false;
                    gameObject.GetComponent<Outline>().enabled = false;
                    m_Collider.enabled = false;
                    iAmSelected = false;
                }
                if (mouseEnter)
                {
                    PaintSelectFactory();
                    ReferenceController.Instance.pieceSelected = true;
                    ReferenceController.Instance.pieceName = gameObject.name;
                    iAmSelected = true;
                }
            }
            if (gameObject.name == ReferenceController.Instance.pieceName && ReferenceController.Instance.pieceSelected)
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

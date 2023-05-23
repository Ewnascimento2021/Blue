using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PiecesController : MonoBehaviour
{
    private Collider m_Collider;
    private bool mouseEnter;
    public string factoryName;
    private bool iAmSelected;

    void Start()
    {
        //m_Collider = GetComponent<Collider>();
        //m_Collider.enabled = false;
    }

    void Update()
    {
        if (mouseEnter && !iAmSelected && !ReferenceController.Instance.isPieceSelected)
        {
            ReferenceController.Instance.factoryName = factoryName;
        }
        if (ReferenceController.Instance.factoryName == factoryName)
        {
            if (mouseEnter && !ReferenceController.Instance.isPieceSelected)
            {
                gameObject.GetComponent<Outline>().enabled = true;
                ReferenceController.Instance.pieceName = gameObject.name;
                if (Input.GetMouseButtonDown(0))
                {
                    iAmSelected = true;
                    ReferenceController.Instance.isPieceSelected = true;
                    //////
                    Debug.Log(ReferenceController.Instance.isPieceSelected);
                }
            }
            else if (gameObject.name == ReferenceController.Instance.pieceName)
            {
                gameObject.GetComponent<Outline>().enabled = true;

                if (ReferenceController.Instance.isPieceSelected == true)
                {
                    iAmSelected = true;
                }
            }
            else if (gameObject.name != ReferenceController.Instance.pieceName)
            {
                gameObject.GetComponent<Outline>().enabled = false;
                iAmSelected = false;

            }
            if (ReferenceController.Instance.CancelSelected)
            {
                ReferenceController.Instance.isPieceSelected = false;
                gameObject.GetComponent<Outline>().enabled = false;
                iAmSelected = false;
                ReferenceController.Instance.CancelSelected = false;
            }
        }
        else if (ReferenceController.Instance.factoryName != factoryName)
        {
            gameObject.GetComponent<Outline>().enabled = false;
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

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
        if (mouseEnter && !iAmSelected)
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
            }
        }
        else if (ReferenceController.Instance.factoryName != factoryName)
        {
            gameObject.GetComponent<Outline>().enabled = false;

        }



        //if (Input.GetMouseButtonDown(0) && !mouseEnter)
        //{
        //    m_Collider.enabled = false;
        //    gameObject.GetComponent<Outline>().enabled = false;
        //    ReferenceController.Instance.pieceSelected = false;
        //    ReferenceController.Instance.pieceName = null;
        //    pieceSelect = false;
        //}

        //if (Input.GetMouseButtonDown(0)  && mouseEnter)
        //{   
        //    gameObject.GetComponent<Outline>().enabled = true;
        //    ReferenceController.Instance.pieceSelected = true;
        //    ReferenceController.Instance.pieceName = gameObject.name;
        //    pieceSelect = true;
        //}

        //if (gameObject.name == ReferenceController.Instance.pieceName && ReferenceController.Instance.pieceSelected)
        //{
        //    gameObject.GetComponent<Outline>().enabled = true;
        //    pieceSelect = true;
        //}
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

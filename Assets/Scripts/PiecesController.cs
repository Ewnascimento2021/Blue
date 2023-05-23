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
                    AddPieceList();
                   // ReferenceController.Instance.contPiecesSelected.Add(gameObject);
                   Debug.Log(ReferenceController.Instance.contPiecesSelected.Count);
                }
            }
            else if (gameObject.name == ReferenceController.Instance.pieceName)
            {
                gameObject.GetComponent<Outline>().enabled = true;

                if (ReferenceController.Instance.isPieceSelected == true)
                {
                    iAmSelected = true;
                    AddPieceList();
                  //  ReferenceController.Instance.contPiecesSelected.Add(gameObject);
                  Debug.Log(ReferenceController.Instance.contPiecesSelected.Count);
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
                ReferenceController.Instance.contPiecesSelected.Clear();
                Debug.Log(ReferenceController.Instance.contPiecesSelected.Count);
            }
        }
        else if (ReferenceController.Instance.factoryName != factoryName)
        {
            gameObject.GetComponent<Outline>().enabled = false;
        }

    }

    private void AddPieceList()
    {
        if (!ReferenceController.Instance.contPiecesSelected.Contains(gameObject))
        {
            ReferenceController.Instance.contPiecesSelected.Add(gameObject);
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

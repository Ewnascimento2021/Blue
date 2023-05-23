using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterPiece : MonoBehaviour
{
    [SerializeField]
    private int numberLine;

    private bool mouseEnter;

    


    void Start()
    {
        
    }

 
    void Update()
    {
        if (ReferenceController.Instance.isPieceSelected)
        {
            if (Input.GetMouseButtonDown(0) && mouseEnter)
            {

            }
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

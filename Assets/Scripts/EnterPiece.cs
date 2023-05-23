using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterPiece : MonoBehaviour
{
    private bool mouseEnter;

    void Start()
    {
        
    }

 
    void Update()
    {
        if (ReferenceController.Instance.isPieceSelected && mouseEnter)
        {
            gameObject.GetComponent<Outline>().enabled = true;
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

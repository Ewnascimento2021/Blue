using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterPiece : MonoBehaviour
{
    [SerializeField]
    private int numberLine;

    private bool mouseEnter;

    private bool houseSelected;

    private bool nullPiece;
    


    void Start()
    {
        
    }

 
    void Update()
    {
        if (ReferenceController.Instance.isPieceSelected)
        {
            if (mouseEnter)
            {
                gameObject.GetComponent<Outline>().enabled = true;

                if (Input.GetMouseButtonDown(0))
                {
                    ReferenceController.Instance.lineSelected = numberLine;

                    houseSelected = true;

                    ReferenceController.Instance.HoldPieces();
                }
            }
            else if (!mouseEnter) 
            {
                gameObject.GetComponent<Outline>().enabled = false;
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

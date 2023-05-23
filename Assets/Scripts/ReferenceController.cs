using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReferenceController : MonoBehaviour
{
    static ReferenceController instance;
    public static ReferenceController Instance
    {
        get
        {
            if (instance == null)
                instance = FindObjectOfType<ReferenceController>();
            return instance;
        }
    }


    public List<GameObject> contPiecesSelected = new List<GameObject>();

    public bool isPieceSelected;

    public string pieceName;

    public bool factorySelected;

    public string factoryName;

    public bool CancelSelected;

    public Transform corcoordinatesHouse;

    

    private void HouseSelected()
    {


    }

}

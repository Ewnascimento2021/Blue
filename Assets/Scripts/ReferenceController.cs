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

    public GameObject[,] board;


    public bool pieceSelected;
    public string pieceName;
    public string factoryName;
    public int factorySelected;


    void Update()
    {
        Debug.Log(pieceName);
    }


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.PlayerSettings;

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

    public Vector3[,] corcoordinatesHouse;


    public bool isPieceSelected;

    public string pieceName;

    public bool factorySelected;

    public string factoryName;

    public bool cancelSelected;

    public int lineSelected;

    public bool otherPlayer;


    private void Start()
    {

    }

    public void HoldPieces()
    {
        switch (lineSelected)
        {
            case 1:

                if (contPiecesSelected.Count == 1)
                {
                    Vector3 spawn1Pos1 = new Vector3(5.15f, 0.67f, -14.90f);
                    contPiecesSelected[0].transform.position = spawn1Pos1;
                    contPiecesSelected.RemoveAt(0);
                }
                break;

            case 2:
                if (contPiecesSelected.Count == 2)
                {
                    Vector3 spawn2Pos1 = new Vector3(5.15f, 0.67f, -13.65f);
                    contPiecesSelected[0].transform.position = spawn2Pos1;
                    contPiecesSelected.RemoveAt(0);

                    Vector3 spawn2Pos2 = new Vector3(6.41f, 0.67f, -13.65f);
                    contPiecesSelected[0].transform.position = spawn2Pos2;
                    contPiecesSelected.RemoveAt(0);

                }
                break;

            case 3:
                if (contPiecesSelected.Count == 3)
                {
                    Vector3 spawn3Pos1 = new Vector3(5.15f, 0.67f, -12.44f);
                    contPiecesSelected[0].transform.position = spawn3Pos1;
                    contPiecesSelected.RemoveAt(0);

                    Vector3 spawn3Pos2 = new Vector3(6.41f, 0.67f, -12.44f);
                    contPiecesSelected[0].transform.position = spawn3Pos2;
                    contPiecesSelected.RemoveAt(0);

                    Vector3 spawn3Pos3 = new Vector3(7.68f, 0.67f, -12.44f);
                    contPiecesSelected[0].transform.position = spawn3Pos3;
                    contPiecesSelected.RemoveAt(0);

                }
                break;

            case 4:
                if (contPiecesSelected.Count == 4)
                {
                    Vector3 spawn4Pos1 = new Vector3(5.15f, 0.67f, -11.2f);
                    contPiecesSelected[0].transform.position = spawn4Pos1;
                    contPiecesSelected.RemoveAt(0);

                    Vector3 spawn4Pos2 = new Vector3(6.41f, 0.67f, -11.2f);
                    contPiecesSelected[0].transform.position = spawn4Pos2;
                    contPiecesSelected.RemoveAt(0);

                    Vector3 spawn4Pos3 = new Vector3(7.68f, 0.67f, -11.2f);
                    contPiecesSelected[0].transform.position = spawn4Pos3;
                    contPiecesSelected.RemoveAt(0);

                    Vector3 spawn4Pos4 = new Vector3(8.9f, 0.67f, -11.2f);
                    contPiecesSelected[0].transform.position = spawn4Pos4;
                    contPiecesSelected.RemoveAt(0);
                }
                break;

        }

    }

}

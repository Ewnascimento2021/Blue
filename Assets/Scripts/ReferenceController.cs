using System.Collections;
using System.Collections.Generic;
using System.Linq;
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


    public List<GameObject> houseLine1 = new List<GameObject>();
    public List<GameObject> houseLine2 = new List<GameObject>();
    public List<GameObject> houseLine3 = new List<GameObject>();
    public List<GameObject> houseLine4 = new List<GameObject>();
    public List<GameObject> houseLine5 = new List<GameObject>();
    public List<GameObject> descart = new List<GameObject>();

    public Vector3[,] corcoordinatesHouse;


    public bool isPieceSelected;

    public string pieceName;

    public bool factorySelected;

    public string factoryName;

    public bool cancelSelected;

    public int lineSelected;

    public bool otherPlayer;

    public bool clearPlay;


    private void Start()
    {

    }

    public void HoldPieces()
    {
        switch (lineSelected)
        {
            case 1:

                if (houseLine1.Count >= 1)
                {
                    TrashPiece();
                }
                if (contPiecesSelected.Count == 1 && houseLine1.Count < 1)
                {
                    Vector3 spawn1Pos1 = new Vector3(5.15f, 0.67f, -14.90f);
                    contPiecesSelected[0].transform.position = spawn1Pos1;
                    contPiecesSelected.RemoveAt(0);
                }
                else if (contPiecesSelected.Count > 1 && houseLine1.Count == 0)
                {
                    Vector3 spawn1Pos1 = new Vector3(5.15f, 0.67f, -14.90f);
                    contPiecesSelected[0].transform.position = spawn1Pos1;
                    contPiecesSelected.RemoveAt(0);

                    TrashPiece();
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

            case 5:
                if (contPiecesSelected.Count == 5)
                {
                    Vector3 spawn5Pos1 = new Vector3(5.15f, 0.67f, -9.90f);
                    contPiecesSelected[0].transform.position = spawn5Pos1;
                    contPiecesSelected.RemoveAt(0);

                    Vector3 spawn5Pos2 = new Vector3(6.41f, 0.67f, -9.90f);
                    contPiecesSelected[0].transform.position = spawn5Pos2;
                    contPiecesSelected.RemoveAt(0);

                    Vector3 spawn5Pos3 = new Vector3(7.68f, 0.67f, -9.90f);
                    contPiecesSelected[0].transform.position = spawn5Pos3;
                    contPiecesSelected.RemoveAt(0);

                    Vector3 spawn5Pos4 = new Vector3(8.9f, 0.67f, -9.90f);
                    contPiecesSelected[0].transform.position = spawn5Pos4;
                    contPiecesSelected.RemoveAt(0);

                    Vector3 spawn5Pos5 = new Vector3(10.16f, 0.67f, -9.90f);
                    contPiecesSelected[0].transform.position = spawn5Pos5;
                    contPiecesSelected.RemoveAt(0);
                }
                break;
        }


    }

    private void TrashPiece()
    {
        if (contPiecesSelected.Count > 0)
        {
            Vector3 spawnTrashPos1 = new Vector3(10.13f, 0.67f, -8.74f);
            contPiecesSelected[0].transform.position = spawnTrashPos1;
            contPiecesSelected.RemoveAt(0);
        }
    }

}

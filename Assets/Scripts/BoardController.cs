using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardController : MonoBehaviour
{
    [SerializeField]
    private Transform target;
    [SerializeField]
    private GameObject factores;
    [SerializeField]
    private GameObject table;
    [SerializeField]
    private GameObject bluePiece;
    [SerializeField]
    private GameObject redPiece;
    [SerializeField]
    private GameObject yellowPiece;
    [SerializeField]
    private GameObject purplePiece;
    [SerializeField]
    private GameObject greenPiece;

    private GameObject[,] board;

    private float initPosX = 1.0f;
    private float initPosZ = 1.0f;


    void Start()
    {
        board = new GameObject[10, 10];

        GenerateGrid();
        //ReferenceController.Instance.board = board;
        CreatePiece();
    }



    void Update()
    {

    }

    private void GenerateGrid()
    {

    }

    private void CreatePiece()
    {
        GameObject piece;

        for (int x = 0; x < 20; x++)
        {
            target.position = new Vector3(initPosX + x * 1.5f, 0.45f, initPosZ);
            piece = Instantiate(bluePiece, target.position, target.rotation);
            piece.name = "BluePiece";
        }
        for (int x = 0; x < 20; x++)
        {
            target.position = new Vector3(initPosX + x * 1.5f, 0.45f, initPosZ + 1.5f);
            piece = Instantiate(greenPiece, target.position, target.rotation);
            piece.name = "GreenPiece";
        }
        for (int x = 0; x < 20; x++)
        {
            target.position = new Vector3(initPosX + x * 1.5f, 0.45f, initPosZ + 3f);
            piece = Instantiate(yellowPiece, target.position, target.rotation);
            piece.name = "YellowPiece";
        }
        for (int x = 0; x < 20; x++)
        {
            target.position = new Vector3(initPosX + x * 1.5f, 0.45f, initPosZ + 4.5f);
            piece = Instantiate(redPiece, target.position, target.rotation);
            piece.name = "RedPiece";
        }
        for (int x = 0; x < 20; x++)
        {
            target.position = new Vector3(initPosX + x * 1.5f, 0.45f, initPosZ + 6f);
            piece = Instantiate(purplePiece, target.position, target.rotation);
            piece.name = "PurplePiece";
        }
    }
}

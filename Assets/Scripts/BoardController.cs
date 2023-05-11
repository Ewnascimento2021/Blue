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

    public GameObject[] pieces;

    private GameObject[,] board;

    private float initPosX = 1.0f;
    private float initPosZ = 1.0f;
    private int rodada;


    void Start()
    {
        board = new GameObject[10, 10];
        RandomRound();
        CreatePiece();
        rodada = 1;
    }



    void Update()
    {

    }

    private void RandomRound()
    {
        //Fab - 1
        int pieceRandom = Random.Range(0, pieces.Length);
        Vector3 spawn1Pos1 = new Vector3(6.6f, 0.6f, -18.80f);
        Instantiate(pieces[pieceRandom], spawn1Pos1, Quaternion.Euler(new Vector3(-90, 0, 0)));

        pieceRandom = Random.Range(0, pieces.Length);
        Vector3 spawn1Pos2 = new Vector3(6.6f, 0.6f, -17.5f);
        Instantiate(pieces[pieceRandom], spawn1Pos2, Quaternion.Euler(new Vector3(-90, 0, 0)));

        pieceRandom = Random.Range(0, pieces.Length);
        Vector3 spawn1Pos3 = new Vector3(5.4f, 0.6f, -17.5f);
        Instantiate(pieces[pieceRandom], spawn1Pos3, Quaternion.Euler(new Vector3(-90, 0, 0)));

        pieceRandom = Random.Range(0, pieces.Length);
        Vector3 spawn1Pos4 = new Vector3(5.4f, 0.6f, -18.80f);
        Instantiate(pieces[pieceRandom], spawn1Pos4, Quaternion.Euler(new Vector3(-90, 0, 0)));


        //Fab - 2
        pieceRandom = Random.Range(0, pieces.Length);
        Vector3 spawn2Pos1 = new Vector3(2.1f, 0.6f, -18.80f);
        Instantiate(pieces[pieceRandom], spawn2Pos1, Quaternion.Euler(new Vector3(-90, 0, 0)));

        pieceRandom = Random.Range(0, pieces.Length);
        Vector3 spawn2Pos2 = new Vector3(2.1f, 0.6f, -17.5f);
        Instantiate(pieces[pieceRandom], spawn2Pos2, Quaternion.Euler(new Vector3(-90, 0, 0)));

        pieceRandom = Random.Range(0, pieces.Length);
        Vector3 spawn2Pos3 = new Vector3(0.90f, 0.6f, -17.5f);
        Instantiate(pieces[pieceRandom], spawn2Pos3, Quaternion.Euler(new Vector3(-90, 0, 0)));

        pieceRandom = Random.Range(0, pieces.Length);
        Vector3 spawn2Pos4 = new Vector3(0.90f, 0.6f, -18.80f);
        Instantiate(pieces[pieceRandom], spawn2Pos4, Quaternion.Euler(new Vector3(-90, 0, 0)));

        //Fab - 3
        pieceRandom = Random.Range(0, pieces.Length);
        Vector3 spawn3Pos1 = new Vector3(-2.7f, 0.6f, -18.80f);
        Instantiate(pieces[pieceRandom], spawn3Pos1, Quaternion.Euler(new Vector3(-90, 0, 0)));

        pieceRandom = Random.Range(0, pieces.Length);
        Vector3 spawn3Pos2 = new Vector3(-2.7f, 0.6f, -17.5f);
        Instantiate(pieces[pieceRandom], spawn3Pos2, Quaternion.Euler(new Vector3(-90, 0, 0)));

        pieceRandom = Random.Range(0, pieces.Length);
        Vector3 spawn3Pos3 = new Vector3(-3.8f, 0.6f, -17.5f);
        Instantiate(pieces[pieceRandom], spawn3Pos3, Quaternion.Euler(new Vector3(-90, 0, 0)));

        pieceRandom = Random.Range(0, pieces.Length);
        Vector3 spawn3Pos4 = new Vector3(-3.8f, 0.6f, -18.80f);
        Instantiate(pieces[pieceRandom], spawn3Pos4, Quaternion.Euler(new Vector3(-90, 0, 0)));

        //Fab - 4
        pieceRandom = Random.Range(0, pieces.Length);
        Vector3 spawn4Pos1 = new Vector3(-7.0f, 0.6f, -18.80f);
        Instantiate(pieces[pieceRandom], spawn4Pos1, Quaternion.Euler(new Vector3(-90, 0, 0)));

        pieceRandom = Random.Range(0, pieces.Length);
        Vector3 spawn4Pos2 = new Vector3(-7.0f, 0.6f, -17.5f);
        Instantiate(pieces[pieceRandom], spawn4Pos2, Quaternion.Euler(new Vector3(-90, 0, 0)));

        pieceRandom = Random.Range(0, pieces.Length);
        Vector3 spawn4Pos3 = new Vector3(-8.3f, 0.6f, -17.5f);
        Instantiate(pieces[pieceRandom], spawn4Pos3, Quaternion.Euler(new Vector3(-90, 0, 0)));

        pieceRandom = Random.Range(0, pieces.Length);
        Vector3 spawn4Pos4 = new Vector3(-8.3f, 0.6f, -18.80f);
        Instantiate(pieces[pieceRandom], spawn4Pos4, Quaternion.Euler(new Vector3(-90, 0, 0)));

        //Fab - 5
        pieceRandom = Random.Range(0, pieces.Length);
        Vector3 spawn5Pos1 = new Vector3(-11.7f, 0.6f, -18.80f);
        Instantiate(pieces[pieceRandom], spawn5Pos1, Quaternion.Euler(new Vector3(-90, 0, 0)));

        pieceRandom = Random.Range(0, pieces.Length);
        Vector3 spawn5Pos2 = new Vector3(-11.7f, 0.6f, -17.5f);
        Instantiate(pieces[pieceRandom], spawn5Pos2, Quaternion.Euler(new Vector3(-90, 0, 0)));

        pieceRandom = Random.Range(0, pieces.Length);
        Vector3 spawn5Pos3 = new Vector3(-12.9f, 0.6f, -17.5f);
        Instantiate(pieces[pieceRandom], spawn5Pos3, Quaternion.Euler(new Vector3(-90, 0, 0)));

        pieceRandom = Random.Range(0, pieces.Length);
        Vector3 spawn5Pos4 = new Vector3(-12.9f, 0.6f, -18.80f);
        Instantiate(pieces[pieceRandom], spawn5Pos4, Quaternion.Euler(new Vector3(-90, 0, 0)));

    }



    private void CreatePiece()
    {
        GameObject piece;

        for (int x = 0; x < 20; x++)
        {
            target.position = new Vector3(initPosX + x * 1.5f, 0.45f, initPosZ);
            piece = Instantiate(bluePiece, target.position, target.rotation);
            piece.name = "Piece" + x;
        }
        for (int x = 0; x < 20; x++)
        {
            target.position = new Vector3(initPosX + x * 1.5f, 0.45f, initPosZ + 1.5f);
            piece = Instantiate(greenPiece, target.position, target.rotation);
            piece.name = "Piece" + (x + 20);
        }
        for (int x = 0; x < 20; x++)
        {
            target.position = new Vector3(initPosX + x * 1.5f, 0.45f, initPosZ + 3f);
            piece = Instantiate(yellowPiece, target.position, target.rotation);
            piece.name = "Piece" + (x + 40);
        }
        for (int x = 0; x < 20; x++)
        {
            target.position = new Vector3(initPosX + x * 1.5f, 0.45f, initPosZ + 4.5f);
            piece = Instantiate(redPiece, target.position, target.rotation);
            piece.name = "Piece" + (x + 60);
        }
        for (int x = 0; x < 20; x++)
        {
            target.position = new Vector3(initPosX + x * 1.5f, 0.45f, initPosZ + 6f);
            piece = Instantiate(purplePiece, target.position, target.rotation);
            piece.name = "Piece" + (x + 80);
        }
    }


}

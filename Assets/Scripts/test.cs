using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class test : MonoBehaviour
{

    public GameObject text;

    void Start()
    {
        /*     RookPiece rookW1 = new RookPiece((int)Side.White, new int[1, 2] { { (int)Pos.g, 1 } });
             int[,] a = rookW1.GetPosition();
             List<Piece> pieces = new List<Piece>();
             pieces.Add(rookW1);
             print(a[0,0]+" "+ a[0, 1]);
             print(White.King);
             print(Black.King);
             foreach(Piece x in pieces)
             {
                 print(x.GetID());
             }
             */

        BasicChessGame newGame = new BasicChessGame();
        char[,] thisBoard = newGame.GetBoardState();

        Console.OutputEncoding = System.Text.Encoding.Unicode;
 
        string str = " ";
        for (int i = 0; i < 8; i++)
        {
            str = " ";
            for (int j = 1; j < 8; j++)
            {
                str += thisBoard[j, i] + " ";
            }
            print(str);
        }
    }
}

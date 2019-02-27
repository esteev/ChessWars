using System.Collections;
using System.Collections.Generic;
using UnityEngine;

enum Pos
{
    a,b,c,d,e,f,g,h
}

static class White
{
    public static readonly char King =      '\u2654';
    public static readonly char Queen =     '\u2655';
    public static readonly char Rook =      '\u2656';
    public static readonly char Bishop =    '\u2657';
    public static readonly char Knight =    '\u2658';
    public static readonly char Pawn =      '\u2659';

    public static readonly char[] pieces = { King, Queen, Rook, Bishop, Knight, Pawn };
}

static class Black
{
    public static readonly char King =      '\u265A';
    public static readonly char Queen =     '\u265B';
    public static readonly char Rook =      '\u265C';
    public static readonly char Bishop =    '\u265D';
    public static readonly char Knight =    '\u265E';
    public static readonly char Pawn =      '\u265F';

    public static readonly char[] pieces = { King, Queen, Rook, Bishop, Knight, Pawn };
}

/*
 * Create a chessboard of any size for any type of game(different scripts)
 * Can add any amount of pieces to it. Add Pieces one by one or by a Piece List.
 * GetBoard and SetBoardLayout for saving and loading existing games.
 * CalibrateBoard is called after adding in pieces so as to calculate current piece positions.
 */


public class ChessBoard
{
    public char[,] board;
    public List<Piece> pieces = new List<Piece>();

    public ChessBoard(int size)
    {
        board = new char[size, size];
    }

    public char[,] GetBoard()
    {
        return board;
    }

    public void SetBoardLayout(char[,] layout)
    {
        board = layout;
    }

    public void AddPiece(Piece piece)
    {
        pieces.Add(piece);
        CalibrateBoard();
    }

    public void AddPiece(List<Piece> pieceList)
    {
        pieces = pieceList;
        CalibrateBoard();
    }

    public void CalibrateBoard()
    {
        foreach(Piece x in pieces)
        {
            char ch = x.GetID();
            int[,] temp = x.GetPosition();
            board[temp[0, 0], temp[0, 1]] = ch;
        }

        
    }
}
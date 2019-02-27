using System.Collections;
using System.Collections.Generic;
using UnityEngine;

enum Side
{
    White, Black
}

public class BasicChessGame
{
    private const int SIZE = 8;

    private ChessBoard chessBoard;

    private bool turn;

    public BasicChessGame()
    {
        chessBoard = new ChessBoard(SIZE);
        BasicBoardLayout();
        turn = true;                              //White
    }
   
    public void ChangeTurn()
    {
        turn = !turn;
    }

    public char[,] GetBoardState()
    {
        return chessBoard.GetBoard();
    }

    private void BasicBoardLayout()
    {
            List<Piece> BasicPieceLayout = new List<Piece>();
            // Adding white pieces
            RookPiece rookW1 = new RookPiece((int)Side.White, new int[1, 2] { { (int)Pos.a, 0 } });
            RookPiece rookW2 = new RookPiece((int)Side.White, new int[1, 2] { { (int)Pos.h, 0 } });
            KnightPiece knightW1 = new KnightPiece((int)Side.White, new int[1, 2] { { (int)Pos.b, 0 } });
            KnightPiece knightW2 = new KnightPiece((int)Side.White, new int[1, 2] { { (int)Pos.g, 0 } });
            BishopPiece bishopW1 = new BishopPiece((int)Side.White, new int[1, 2] { { (int)Pos.c, 0 } });
            BishopPiece bishopW2 = new BishopPiece((int)Side.White, new int[1, 2] { { (int)Pos.f, 0 } });
            QueenPiece queenW = new QueenPiece((int)Side.White, new int[1, 2] { { (int)Pos.d, 0 } });
            KingPiece kingW = new KingPiece((int)Side.White, new int[1, 2] { { (int)Pos.e, 0 } });
            PawnPiece[] pawnsW = new PawnPiece[8];
            for (int i=0;i<8;i++)
            {
                pawnsW[i] = new PawnPiece((int)Side.White, new int[1, 2] { { i, 1 } });
                BasicPieceLayout.Add(pawnsW[i]);
            }
            BasicPieceLayout.Add(rookW1);
            BasicPieceLayout.Add(rookW2);
            BasicPieceLayout.Add(knightW1);
            BasicPieceLayout.Add(knightW2);
            BasicPieceLayout.Add(bishopW1);
            BasicPieceLayout.Add(bishopW2);
            BasicPieceLayout.Add(queenW);
            BasicPieceLayout.Add(kingW);

            // Adding black pieces
            RookPiece rookB1 = new RookPiece((int)Side.White, new int[1, 2] { { (int)Pos.a, 7 } });
            RookPiece rookB2 = new RookPiece((int)Side.White, new int[1, 2] { { (int)Pos.h, 7 } });
            KnightPiece knightB1 = new KnightPiece((int)Side.White, new int[1, 2] { { (int)Pos.b, 7 } });
            KnightPiece knightB2 = new KnightPiece((int)Side.White, new int[1, 2] { { (int)Pos.g, 7 } });
            BishopPiece bishopB1 = new BishopPiece((int)Side.White, new int[1, 2] { { (int)Pos.c, 7 } });
            BishopPiece bishopB2 = new BishopPiece((int)Side.White, new int[1, 2] { { (int)Pos.f, 7 } });
            QueenPiece queenB = new QueenPiece((int)Side.White, new int[1, 2] { { (int)Pos.d, 7 } });
            KingPiece kingB = new KingPiece((int)Side.White, new int[1, 2] { { (int)Pos.e, 7 } });
            PawnPiece[] pawnsB = new PawnPiece[8];
            for (int i = 0; i < 8; i++)
            {
                pawnsB[i] = new PawnPiece((int)Side.White, new int[1, 2] { { i, 6 } });
                BasicPieceLayout.Add(pawnsB[i]);
            }
            BasicPieceLayout.Add(rookB1);
            BasicPieceLayout.Add(rookB2);
            BasicPieceLayout.Add(knightB1);
            BasicPieceLayout.Add(knightB2);
            BasicPieceLayout.Add(bishopB1);
            BasicPieceLayout.Add(bishopB2);
            BasicPieceLayout.Add(queenB);
            BasicPieceLayout.Add(kingB);

            chessBoard.AddPiece(BasicPieceLayout);
    }
}
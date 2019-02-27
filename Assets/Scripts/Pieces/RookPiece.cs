public class RookPiece: Piece
{
    char idWhite = White.Rook;
    char idBlack = Black.Rook;

    public RookPiece(int color, int[,] position): base(color, position)
    {
        
    }

    override public char GetID()
    {
        if (color == (int)Side.White)
            return idWhite;
        else
            return idBlack;
    }
}

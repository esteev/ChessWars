public class QueenPiece: Piece
{
    char idWhite = White.Queen;
    char idBlack = Black.Queen;

    public QueenPiece(int color, int[,] position) : base(color, position)
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

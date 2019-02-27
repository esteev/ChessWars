public class KnightPiece: Piece
{
    char idWhite = White.Knight;
    char idBlack = Black.Knight;

    public KnightPiece(int color, int[,] position) : base(color, position)
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

public class KingPiece: Piece
{
    char idWhite = White.King;
    char idBlack = Black.King;

    public KingPiece(int color, int[,] position) : base(color, position)
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

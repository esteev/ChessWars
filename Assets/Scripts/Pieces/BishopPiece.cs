public class BishopPiece: Piece
{
    char idWhite = White.Bishop;
    char idBlack = Black.Bishop;

    public BishopPiece(int color, int[,] position) : base(color, position)
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

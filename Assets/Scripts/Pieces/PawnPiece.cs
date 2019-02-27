public class PawnPiece: Piece
{
    char idWhite = White.Pawn;
    char idBlack = Black.Pawn;

    public PawnPiece(int color, int[,] position) : base(color, position)
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

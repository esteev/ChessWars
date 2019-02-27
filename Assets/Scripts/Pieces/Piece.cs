public class Piece
{
    protected int color;
    protected int[,] position;

    public Piece(int color, int[,] position)
    {
        this.color = color;
        this.position = position;
    }

    public void ChangePosition(int[,] newPosition)
    {
        position = newPosition;
    }

    public int[,] GetPosition()
    {
        return position;
    }

    public virtual char GetID()
    {
        return '\0';
    }

    public int GetColor()
    {
        return color;
    }
}

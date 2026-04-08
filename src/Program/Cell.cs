

public class cell
{
    private bool isAlive;
    public bool IsAlive
    {
        get {return this.isAlive;} set {this.isAlive = value;}
    }

    public cell(bool lifeStatus)
    {
        this.isAlive = lifeStatus;
    }
}
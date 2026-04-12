
namespace Ucu.Poo.GameOfLife
{
    public class Cell
    {
        private bool isAlive;
        public bool IsAlive
        {
            get {return this.isAlive;} set {this.isAlive = value;}
        }

        public Cell(bool lifeStatus)
        {
            this.isAlive = lifeStatus;
        }
    }
}
namespace Labyrinthe
{
	public class Wall : Tile
	{
        public override bool IsTraversable => false;

        public override bool Pass()
        {
            return IsTraversable;
        }
    }
}
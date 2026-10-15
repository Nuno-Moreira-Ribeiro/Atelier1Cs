namespace Labyrinthe
{
	public class Room : Tile
	{
        public override bool IsTraversable => true;
		ICollectable? collectable { get; }

		public Room(ICollectable? collectable)
		{
			this.collectable = collectable;
		}

        public override bool Pass()
        {
			return IsTraversable;
        }
    }
}
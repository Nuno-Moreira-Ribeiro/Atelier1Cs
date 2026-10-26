namespace Labyrinthe
{
	public class Room : Tile
	{
        public override bool IsTraversable => true;
		public ICollectable? Collectable { get; private set; }

		public Room(ICollectable? collectable)
		{
			this.Collectable = collectable;
		}

		public ICollectable? TakeCollectable()
		{
			var item = Collectable;
			Collectable = null;
			return item;
		}

        public override bool Pass()
        {
			return IsTraversable;
        }
    }
}
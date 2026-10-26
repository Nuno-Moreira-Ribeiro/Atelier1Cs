namespace Labyrinthe
{
    public class Door : Tile
    {
        private bool isTraversable = false;
        public override bool IsTraversable => isTraversable;
        public Key Key { get; }

        public Door()
        {
            Key = new Key();
        }

        public bool OpenClose(Key key)
        {
            if (ReferenceEquals(key, this.Key))
            {
                isTraversable = !isTraversable;
            }
            return IsTraversable;
        }

        public override bool Pass() => IsTraversable;
    }
}

namespace Labyrinthe
{
    public class Door : Tile
    {
        private bool isTraversable = false;
        public override bool IsTraversable => isTraversable;
        Key key { get; }

        public Door()
        {
            key = new Key();
        }

        public bool Open(Key key)
        {
            isTraversable = isTraversable || ReferenceEquals(key, this.key);
            return IsTraversable;
        }

        public override bool Pass() => IsTraversable;
    }
}

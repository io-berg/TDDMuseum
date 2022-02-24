namespace src
{
    public class Room
    {
        public string Name { get; private set; }

        List<Artwork> _art = new();

        public Room(string Name)
        {
            this.Name = Name;
        }

        public void AddArtwork(Artwork artwork)
        {
            if(_art.Count >= 3) throw new Exception("Room already contains 3 artwork, more cant be added");
            _art.Add(artwork);
        }

        public List<Artwork> GetArtwork()
        {
            return _art;
        }
    }
}
namespace src
{
    public class Museum
    {
        public string Name { get; private set; }

        List<Room> _rooms = new();

        public Museum(string Name)
        {
            this.Name = Name;
        }

        public List<Room> GetRooms()
        {
            return _rooms;
        }

        public void AddRoom(Room room)
        {
            _rooms.Add(room);
        }

        public bool DeleteRoom(Room room)
        {
            if(room.GetArtwork().Count > 0) return false;
            else 
            {
                _rooms.Remove(room);
                return true;
            }
        }
    }
}
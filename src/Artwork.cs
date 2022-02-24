namespace src
{
    public class Artwork
    {
        public string Titel { get; private set; }
        public string Description { get; private set; }
        public string Maker { get; private set; }

        public Artwork(string Titel, string Description, string Maker)
        {
            this.Titel = Titel;
            this.Description = Description;
            this.Maker = Maker;
        }
    }
}
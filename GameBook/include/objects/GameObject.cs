namespace GameBook.include.objects
{
    public class gameObject
    {
        private string gameID;
        private string gameTitle;
        private string releaseDate;
        private string gameVersion;
        private string gameCategory;
        private string gamePrice;
        public gameObject()
        {
            GameID = GameTitle = ReleaseDate = GameVersion = GameCategory = GamePrice = "";
        }
        public gameObject(string gameID,string gameTitle, string releaseDate, string gameVersion, string gameCategory, string gamePrice)
        {
            this.gameID = gameID;
            this.gameTitle = gameTitle;
            this.releaseDate = releaseDate;
            this.gameVersion = gameVersion;
            this.gameCategory = gameCategory;
            this.gamePrice = gamePrice;
        }

        public string GameID { get => gameID; set => gameID = value; }
        public string GameTitle { get => gameTitle; set => gameTitle = value; }
        public string ReleaseDate { get => releaseDate; set => releaseDate = value; }
        public string GameVersion { get => gameVersion; set => gameVersion = value; }
        public string GameCategory { get => gameCategory; set => gameCategory = value; }
        public string GamePrice { get => gamePrice; set => gamePrice = value; }
    }
}

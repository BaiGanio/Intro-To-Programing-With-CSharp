namespace MovieTitles
{
    internal class MovieInfo
    {
        public string Title { get; set; }
        public int Year { get; set; }
        public string IMDbId { get; set; }

        public override string ToString()
        {
            return $"| {Title, -60} | {Year} | {IMDbId} |";
        }
    }
}

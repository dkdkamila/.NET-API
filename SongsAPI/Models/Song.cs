namespace SongsAPI.Models
{
    public class Song
    {
        //Properties
        public int SongId { get; set; }

        public string? Artist { get; set; }

        public string? Title { get; set; }
        public int Length { get; set; }
        public string? Genre { get; set; }
    }
}

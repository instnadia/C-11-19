namespace Day_1
{
    public class Movies
    {
        public string name;
        public string genre;
        double score;
        int lengthOfMovie;

        public Movies(string name, string genre, double score, int length){
            this.genre = genre;
            this.name = name;
            this.score = score;
            this.lengthOfMovie = length;
        }
    }
}
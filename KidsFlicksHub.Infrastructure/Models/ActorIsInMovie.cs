namespace KidsFlicksHub.Infrastructure.Models
{
    public class ActorIsInMovie
    {
        public int ActorId { get; set; }
        public Actor? Actor { get; set; }

        public int MovieId { get; set; }
        public Movie? Movie { get; set; }

        public ICollection<Movie> Movies { get; set;} = new List<Movie>();
        public ICollection<Actor> Actors { get; set;} = new List<Actor>();  
    }
}

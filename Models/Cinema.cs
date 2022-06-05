namespace TicketApp.Models
{
    public class Cinema
    {
        public int Id { get; set; }
        public string? FullName { get; set; }
        public string? Description { get; set; }
        //Relationship
        public List<Movie>? Movies { get; set; }
    }
}

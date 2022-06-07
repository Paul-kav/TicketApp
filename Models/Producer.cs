namespace TicketApp.Models
{
    public class Producer
    {
        public int Id { get; set; }
        public string? FullName { get; set; }
        public string? Description { get; set; }
        //Relationship
        public List<Movie>? Movies { get; set; }

        /*public static implicit operator Producer(int v)
        {
            throw new NotImplementedException();
        }*/
    }
}

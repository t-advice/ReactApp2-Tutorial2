namespace ReactApp1.Server.Models
{
    public class TodoItem
    {
        // The Primary Key(ID)
        public int Id { get; set; }

        // The actual task text ( lets say "Buy groceries" )
        public string? Title { get; set; }

        // Is it done yet?
        public bool IsCompleted { get; set; }

    }
}

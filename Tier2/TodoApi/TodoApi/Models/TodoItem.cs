namespace TodoApi.Models
{
    public class TodoItem
    {
        public long Id { get; set; }
        public string? Name { get; set; }
        public bool IsComplete { get; set; }
        public string? Secret { get; set; } // The secret field needs to be hidden from this app,
                                            // but an administrative app could choose to expose it.
    }
}

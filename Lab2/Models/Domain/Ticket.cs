namespace Lab2.Models.Domain
{
    public class Ticket
    {
        #region Props

        public Guid Id { get; set; }
        public string? Title { get; set; }
        public double Price { get; set; }
        public string Status { get; set; }

        #endregion

        #region constructors 

        public Ticket() { }
        public Ticket(Guid id,
            string title,
            double price)
        {
            Id = id;
            Title = title;
            Price = price;
        }

        #endregion

        #region Initial List

        private static readonly List<Ticket> _Tickets = new()
                    {
                        new Ticket(Guid.NewGuid(), "The Great Gatsby", 12.99),
                        new Ticket(Guid.NewGuid(), "To Kill a Mockingbird",  10.99),
                        new Ticket(Guid.NewGuid(), "1984", 9.99),
                        new Ticket(Guid.NewGuid(), "Pride and Prejudice", 7.99),
                        new Ticket(Guid.NewGuid(), "The Catcher in the Rye", 11.99),
                        new Ticket(Guid.NewGuid(), "Brave New World", 8.99),
                        new Ticket(Guid.NewGuid(), "The Hobbit", 13.99),
                        new Ticket(Guid.NewGuid(), "The Lord of the Rings", 29.99),
                        new Ticket(Guid.NewGuid(), "The Hitchhiker's Guide to the Galaxy", 6.99),
                        new Ticket(Guid.NewGuid(), "Harry Potter and the Philosopher's Stone", 14.99)
                    };

        #endregion

        public static List<Ticket> GetTicketsList() => _Tickets;
    }
}



namespace Dofus_HDV.Data
{
    public class User
    {
        public string UserID { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public string Email { get; set; }
        public DateTime CreatedAt { get; set; }

        // Collection de transaction
        public ICollection<Transaction> Transactions { get; set; }

        // Créer un nouvel utilisateur
        public User(string username, string passwordHash, string email)
        {
            Username = username;
            PasswordHash = passwordHash;
            Email = email;
            CreatedAt = DateTime.Now;
            Transactions = new HashSet<Transaction>();
        }
    }
}


namespace ProjectTouristManagmentSystem
{
    internal class User : IObserver
    {
        public string Email { get; set; }

        public User(string email)
        {
            Email = email;
        }

        public void Update(string message)
        {
            // Send notification (e.g., email) to the user
            Console.WriteLine($"Notification to {Email}: {message}");
        }
    }
}

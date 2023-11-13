namespace RandomHobby
{
    class RandomHobby
    {
        static string GetHobby()
        {
            string[] hobbies = {"Guitar", "Photography", "Cats", "Gaming", "Geocaching", "Programming"};
            Random rand = new Random();
            int randomIndex = rand.Next(0, hobbies.Length);
            return "Your new hobby is: " + hobbies[randomIndex];
        }
        static void Main()
        {
            Console.WriteLine("Hi! What's your name?");
            string? name = Console.ReadLine();
            string newHobby = GetHobby();
            string message = $"Hello {name}! Your new hobby is {newHobby}.";
            Console.WriteLine(message);
        }
    }
}
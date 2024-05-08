namespace Constructors_DamienAdkisson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //get and set my favorite game
            Game myGame = new Game("Rainbow Six Siege", "FPS");
            //print my fav game
            Console.WriteLine($"My favorite game is {myGame.title} and it is a(n) {myGame.genre} game!");
            //grabs the default params 
            Game myOtherGame = new Game();
            //prints the defaults
            Console.WriteLine($"My other favorite game is {myOtherGame.title} and it is a(n) {myOtherGame.genre}game!");

            
        }
    }
}
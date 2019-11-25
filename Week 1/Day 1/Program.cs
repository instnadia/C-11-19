using System;

namespace Day_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Movies pinappleexpress = new Movies("PE", "comedy",4.5, 100);
            Movies LordOfTheRings = new Movies("LOTR", "fantasy", 5, 900);
            Netflix myNetflix = new Netflix("123@gmail.com",123, "Nadia");
            myNetflix.ShowOwner = "Michelle";
            Console.WriteLine(myNetflix.ShowOwner);
            myNetflix.addToPlaylist(pinappleexpress);
            myNetflix.addToPlaylist(LordOfTheRings);
            myNetflix.showLibrary();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors_DamienAdkisson
{
    internal class Game
    {
        //makes variables for use in the constructor
        public string title, genre;

        //sets default params
        public Game(string titleParam = "Unkown Title", string genreParam = "Casual")
        {
            title = titleParam;
            genre = genreParam;
        }
    }
}

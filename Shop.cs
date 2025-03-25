using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

//the purpose of this class is to handle all combat interactions
//feel free to add some unique combat features as we will be adding random effects over time
//remeber RNG is the king of fighters as long as its managable
namespace Food_Crawler
{
    class Shop
    {

        private static void Options(ref Player player)
        {
            Random rnd = new Random();
            int cost;
            int speedFood = rnd.Next(11);
            int attackFood = rnd.Next(11);
            int damageFood = rnd.Next(11);
            int defenseFood = rnd.Next(11);
            Console.WriteLine($"{player.GetName()} sees {speedFood} speed food, {attackFood} attack food, {damageFood} damage food, and {defenseFood} defense food.");

        }
    }
}

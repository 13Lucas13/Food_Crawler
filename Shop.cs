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
            
            int speedFood = rnd.Next(11);
            int speedCost = rnd.Next(11,31);
            int attackFood = rnd.Next(11);
            int attackCost = rnd.Next(11, 31);
            int damageFood = rnd.Next(11);
            int damageCost = rnd.Next(11, 31);
            int defenseFood = rnd.Next(11);
            int defenseCost = rnd.Next(11, 31);
            Console.WriteLine($"{player.GetName()} sees {speedFood} speed food costing ${speedCost} each, {attackFood} attack food costing ${attackCost} each, {damageFood} damage food costing ${damageCost} each, and {defenseFood} defense food costing ${defenseCost} each.");

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonFinal
{
    public class RandomGenerator
    {
        private static Random _instance;
        //private static Random _randomNumber;

        private RandomGenerator() 
        {
            //_randomNumber = new Random();
        }

        public static Random Instance
        {
            get
            {                
                if (_instance == null)
                {
                    _instance = new Random();
                }
                return _instance;
            }
        }
        
        private Random getRandomNumber()
        {
            return _instance;
        }
    }
}

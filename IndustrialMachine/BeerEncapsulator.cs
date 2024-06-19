using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IndustrialMachine
{
    public class BeerEncapsulator
    {
        private float avalaibleBeerVolume { get; set; } // beer volume (dL) avaiable in the machine 
        private int avalaibleBottles { get; set; } // number of avaiable bottles 
        private int avalaibleCapsules { get; set; } // number of avaiable capsules

        // constructor
        public BeerEncapsulator(float avalaibleBeerVolume, int avalaibleBottles, int avalaibleCapsules)
        {
            this.avalaibleBeerVolume = avalaibleBeerVolume;
            this.avalaibleBottles = avalaibleBottles;
            this.avalaibleCapsules = avalaibleCapsules;
        }

        //public BeerEncapsulator() { } // empty constructor

        public void AddBeer() // method to add 30 cl beer
        {
            avalaibleBeerVolume -= 30;
            avalaibleBottles -= 1;
            avalaibleCapsules -= 1;
        }


        public int ProduceEncapsulatedBeerBottles(int bottlesToProduce)// method to calculate the number of produced bottles and how many capsules or bottles are needed to buy 
        {
            int producedBottles = 0;
            if (bottlesToProduce <= avalaibleBottles && bottlesToProduce <= avalaibleCapsules) // if there is enough bottles
            {
                producedBottles = bottlesToProduce;
            }
            else if (bottlesToProduce > avalaibleBottles)// if there are not enough bottles 
            {
                Console.WriteLine("You don't have enough bottles to produce " + bottlesToProduce + " encapsulated bottles fo beer.");
                int bottlesToBuy = bottlesToProduce - avalaibleBottles;
                Console.WriteLine("You need to buy " + bottlesToBuy + " bottles.");

                if (avalaibleBottles > avalaibleCapsules) // if not enough capsules
                {
                    producedBottles = avalaibleCapsules;
                }
                else if (avalaibleBottles < avalaibleCapsules) // if not enough bottles
                {
                    producedBottles = avalaibleBottles;
                }

            }
            else if (bottlesToProduce > avalaibleCapsules) // if not enough capsules
            {
                Console.WriteLine("You don't have enough capsules to produce " + bottlesToProduce + " encapsulated bottles.");
                int capsulesToBuy = bottlesToProduce - avalaibleCapsules;
                Console.WriteLine("You need to buy " + capsulesToBuy + " capsules.");

                if (avalaibleBottles > avalaibleCapsules) // if not enough capsules
                {
                    producedBottles = avalaibleBottles;
                }
                else if (avalaibleBottles < avalaibleCapsules) // if not enough bottles
                {
                    producedBottles = avalaibleBottles;
                }

                if (avalaibleBottles == 0 || avalaibleCapsules == 0)
                {
                    producedBottles = 0;
                }
            }


            return producedBottles; // return the number of bottles produced according to the stock
        }
    }
}
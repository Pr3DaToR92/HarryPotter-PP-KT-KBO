using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotter_PP_KT_KBO
{
    internal class House
    {

        public string Houses { get; set; }

        public House(string house)
        {
            Houses = house;
        }

        public static void GetHouseName()
        {
            List<House> houses = new List<House>();

            House house1 = new House("Gryffindor");
            House house2 = new House("Slytherin");
            House house3 = new House("Hufflepuff");
            House house4 = new House("Ravenclaw");

            houses.Add(house1);
            houses.Add(house2);
            houses.Add(house3);
            houses.Add(house4);
        }
        
    }
}





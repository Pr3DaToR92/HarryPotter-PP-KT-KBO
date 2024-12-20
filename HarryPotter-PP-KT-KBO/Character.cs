using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotter_PP_KT_KBO
{
    internal class Character
    {

        public string potterName { get; set; }

        public House potterHouse { get; set; }

        public string potterInventory { get; set; }
        public Character(string name, string potterHouse, string inventory)
        {

            potterName = name;
            potterHouse = House(potterHouse);
            potterInventory = inventory;
        }

        public void NewCharacter(string name, string potterHouse)
        {
            while (true)
            {
                var userInput = "";
                var charName = name;
                var charHouse = potterHouse;
                switch (userInput = "3")
                {
                    case "1":
                        Console.WriteLine("Skriv inn navn");
                        charName = Console.ReadLine();
                        break;
                    case "2":
                        Console.WriteLine("Velg 1 av 4 hus");
                        Console.WriteLine($House.GetHouseName();
                        
                        charHouse = Console.ReadLine();
                        break;
                    case "3":
                        Console.WriteLine("Gå til Hogwarts");
                        userInput = Console.ReadLine();
                        break;

                }

               

               
            }
            
            
        }
    }

}
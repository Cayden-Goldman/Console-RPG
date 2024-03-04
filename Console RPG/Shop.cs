using System;
using System.Collections.Generic;
using System.Text;

namespace Console_RPG
{
    class Shop : Event
    {
        public string shopName;
        public List<Item> items;

        public Shop(string shopName, List<Item> items) : base(false)
        {
            this.shopName = shopName;
            this.items = items;
        }

        public override void Resolve(List<Player> players)
        {
            Console.WriteLine($"Welcome to {shopName}! We've got anything and everything you could ever need!");
            
            while(!(true == false))
            {
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("SHOP || LEAVE");
                string input = Console.ReadLine().ToLower();
                if (input == "shop")
                {
                    Item item = ChooseItem(this.items);
                    if (Player.CoinCount >= item.shopPrice)
                    {
                    Player.CoinCount -= item.shopPrice;
                    Player.Inventory.Add(item);
                    Console.WriteLine($"You got {item.name}!");
                    }
                    else
                    {
                        Console.WriteLine($"You do not have enough money for {item.name}");
                    }
                }
                else if (input == "leave")
                {
                    break;
                }
            }

            Console.WriteLine("Bye bye *insert waving gif here*");
        }
        public Item ChooseItem(List<Item> choices)
        {
            Console.WriteLine("Which item would you like to use?");
            for (int i = 0; i < choices.Count; i++)
            {
                Console.Write($"{i + 1}: {choices[i].name} ({choices[i].shopPrice}G) ");
            }
            Console.WriteLine();

            int index = Convert.ToInt32(Console.ReadLine());
            return choices[index - 1];

        }
    }
}

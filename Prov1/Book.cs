using System.Collections.Generic;
using System;


namespace Prov1
{
    public class Book
    {

        static Random generator = new Random();
        public int price;
        string name;
        int rarity;
        string category;
        int actualValue;
        bool cursed;
        int categoryGenerator;
        int nameGenerator;
        int cursedGenerator;
        List<string> nameList = new List<string>() {"Everbane", "Summer", "Overcool", "Bombastic"};
        List<string> categoryList = new List<string>() {"horror", "fantasy", "si-fi", "action", "comedy"};


        //Skapar värdera för boken direkt när klassen är kallad
        public Book()
        {

            actualValue= generator.Next(100, 1000);
            rarity = generator.Next(1, 11);
            categoryGenerator = generator.Next(categoryList.Count);
            category = categoryList[categoryGenerator];
            nameGenerator = generator.Next(nameList.Count);
            name = nameList[nameGenerator];
            cursedGenerator = generator.Next(0, 2);
            if (cursedGenerator == 0)
            {
                cursed = true;
            }
            else if (cursedGenerator == 1)
            {
                cursed = false;
            }

        }
        
        //Skriver värdera på boken
        public void PrintInfo()
        {

            Console.WriteLine("the " + nameList[nameGenerator] + " is:" +
            "\nof the " + categoryList[categoryGenerator] + " category" + 
            "\n" + rarity + "/10 in rarity" + 
            "\npriced at " + Evaluate() + " USD");

        }
        
        public int Evaluate()
        {

            price = actualValue * rarity;
            int realPrice = actualValue * rarity;
            int priceGenerator = generator.Next(0, 2);
            if (priceGenerator == 0)
            {
                return realPrice / 2;
            }
            else if (priceGenerator == 1)
            {
                return realPrice * 3 / 2;
            }
            else
            {
                return realPrice * 3 / 2;
            }

        }

        public string GetCategory()
        {

            return category;
            
        }

        public string GetName()
        {

            return name;

        }

        public bool IsCursed()
        {

            //slump generator 0, 100
            //if och else 80%, 20% för att visa rätt och visa fel för värdet på cursed

        }


    }
}


// + price: int
// - name: string
// - rarity: int
// - category: string
// - actualValue: int
// - cursed: bool
// - generator: Random
// + Book()
// + PrintInfo(): void
// + Evaluate(): int
// + GetCategory(): string
// + GetName(): string
// + IsCursed(): bool


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Hands_of_Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, string> people = new Dictionary<string, string>();
            Dictionary<string, int> personsCardsWithValues = new Dictionary<string, int>();

            while (input != "JOKER")
            {
                string[] splitter = input.Split(new[] { ":" }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string name = splitter[0];

                if (!people.ContainsKey(name))
                {
                    people.Add(name, splitter[1]);
                }
                else
                {
                    people[name] += splitter[1];
                }
                input = Console.ReadLine();
            }

            foreach (var person in people)
            {
                //we are spliting the cards in every person
                List<string> cardValues = person.Value.Split(new[] { ",", " " }, StringSplitOptions.RemoveEmptyEntries).Distinct().ToList();
                int sum = 0;

                //here we finding the value of every card and we sum it
                foreach (var cardValue in cardValues)
                {
                    string power = cardValue[0].ToString();
                    string type = cardValue[cardValue.Length - 1].ToString();
                    if (power == "1")
                    {
                        power = "10";
                    }
                    int powerAsNumber = 0;
                    int typeAsNumber = 0;
                    bool nPower = int.TryParse(power, out powerAsNumber);

                    if (nPower == false)
                    {
                        switch (power)//J, Q, K, A
                        {
                            case "J":
                                powerAsNumber = 11;
                                break;
                            case "Q":
                                powerAsNumber = 12;
                                break;
                            case "K":
                                powerAsNumber = 13;
                                break;
                            case "A":
                                powerAsNumber = 14;
                                break;
                        }
                    }

                    switch (type)//S -> 4, H-> 3, D -> 2, C -> 1
                    {
                        case "S":
                            typeAsNumber = 4;
                            break;
                        case "H":
                            typeAsNumber = 3;
                            break;
                        case "D":
                            typeAsNumber = 2;
                            break;
                        case "C":
                            typeAsNumber = 1;
                            break;
                    }

                    int cardPoints = powerAsNumber * typeAsNumber;
                    sum += cardPoints;

                    //int calculation = card[0] * power;
                }

                //here we are making the connection between the two dictionaries
                if (!personsCardsWithValues.ContainsKey(person.Key))
                {
                    personsCardsWithValues.Add(person.Key, sum);
                }
                else
                {
                    personsCardsWithValues[person.Key] += sum;
                }

            }
            //print the result
            foreach (var personCardWithValue in personsCardsWithValues)
            {
                Console.WriteLine($"{personCardWithValue.Key}: {personCardWithValue.Value}");
            }
        }
    }
}

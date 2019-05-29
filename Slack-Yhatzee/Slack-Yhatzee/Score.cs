using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slack_Yhatzee
{
    class Score
    {
        private int dieValue1;
        private int dieValue2;
        private int dieValue3;
        private int dieValue4;
        private int dieValue5;
        private List<int> diceList = new List<int>();
        private string scoreType;

        public Score(int dieValue1, int dieValue2, int dieValue3, int dieValue4, int dieValue5, string scoreType)
        {

            //Create with the dice you are scoreing and the score you are looking for 


            this.dieValue1 = dieValue1;
            this.dieValue2 = dieValue2;
            this.dieValue3 = dieValue3;
            this.dieValue4 = dieValue4;
            this.dieValue5 = dieValue5;
            this.scoreType = scoreType;

            diceList.Add(dieValue1);
            diceList.Add(dieValue2);
            diceList.Add(dieValue3);
            diceList.Add(dieValue4);
            diceList.Add(dieValue5);
        }

        //Match the string to score type with a switch statement, return the score

        public int returnScore()
        {
            int score = 0;

            switch (scoreType)
            {
                case "Ones":
                    //Score Ones
                    score = upperMatches(1) * 1;
                    break;
                case "Twos":
                    score = upperMatches(2) * 2;
                    break;
                case "Threes":
                    score = upperMatches(3) * 3;
                    break;
                case "Fours":
                    score = upperMatches(4) * 4;
                    break;
                case "Fives":
                    score = upperMatches(5) * 5;
                    break;
                case "Sixes":
                    score = upperMatches(6) * 6;
                    break;
                case "3 of a Kind":
                    if (identicalValues() >= 3)
                    {
                        score = allDiceTotal();
                    }
                    break;
                case "4 of a Kind":
                    if (identicalValues() >= 4)
                    {
                        score = allDiceTotal();
                    }
                    break;
                case "Yhatzee":
                    if (identicalValues() >= 5)
                    {
                        score = allDiceTotal();
                    }
                    break;
                case "Chance":
                    score = allDiceTotal();
                    break;
                case "Small Straight":
                    if(numberOfConsecutiveValues() >= 4)
                    {
                        score = 30;
                    }
                    break;
                case "Large Straight":
                    if (numberOfConsecutiveValues() >= 5)
                    {
                        score = 40;
                    }
                    break;
                case "Full House":
                    if (doesFullHouseExist() == true)
                    {
                        score = 25;
                    }
                    break;
            }

            return score;
        }

        private int upperMatches(int numberToMatch)
        {
            int matches = 0;

            for(int i = 0; i < 5; i++)
            {
                if (diceList[i] == numberToMatch)
                {
                    matches++;
                }
            }

            return matches;
        }

        private int identicalValues()
        {
            //Use for 3, 4 and Yhatzee
            int numberOfIdenticalValues = 0;

            //These are the values on the dice
            int one = 0;
            int two = 0;
            int three = 0;
            int four = 0;
            int five = 0;
            int six = 0;

            for(int i = 0; i < 5; i++)
            {
                //Count the number of times each number shows up
                if(diceList[i] == 1)
                {
                    one++;
                }
                else if (diceList[i] == 2)
                {
                    two++;
                }
                else if (diceList[i] == 3)
                {
                    three++;
                }
                else if (diceList[i] == 4)
                {
                    four++;
                }
                else if (diceList[i] == 5)
                {
                    five++;
                }
                else if (diceList[i] == 6)
                {
                    six++;
                }
            }

            //Determine how many of one number show up in this round
            //Maximum is 5 (A Yhatzee)

            if(one == 5 || two == 5 || three == 5 || four == 5 || five == 5 || six == 5)
            {
                //Yhatzee
                numberOfIdenticalValues = 5;
            }
            else if (one == 4 || two == 4 || three == 4 || four == 4 || five == 4 || six == 4)
            {
                //4 of a kind
                numberOfIdenticalValues = 4;
            }
            else if (one == 3 || two == 3 || three == 3 || four == 3 || five == 3 || six == 3)
            {
                //4 of a kind
                numberOfIdenticalValues = 3;
            }
            else
            {
                //2 or fewer so we don't care
                //Already set to 0 but reassigning for clarity
                numberOfIdenticalValues = 0;
            }

            return numberOfIdenticalValues;
        }

        private int allDiceTotal()
        {
            int total = 0;

            //Return the total of all the dice
            for(int i = 0; i < 5; i++)
            {
                total += diceList[i];
            }

            return total;
        }

        private int numberOfConsecutiveValues()
        {
            //This is only used for small or large straight, only need 4 or 5 in a row
            
            int numberOfValues = 0;

            //I used Stack Overflow to get this method of removing duplicate values from my list
            //https://stackoverflow.com/questions/47752/remove-duplicates-from-a-listt-in-c-sharp
            List<int> copyOfDiceList = diceList.Distinct().ToList(); //This is so I do not change the actual dice list

            //Sort smallest to largest
            copyOfDiceList.Sort();

            //Remove duplicate numbers
            //for(int i = 0; i<4; i++)
            //{
            //   // if(copyOfDiceList[i])
            //}

            //Small combos:
            //1,2,3,4
            //2,3,4,5
            //3,4,5,6
            //Large Combos:
            //1,2,3,4,5
            //2,3,4,5,6

            if (copyOfDiceList.Count < 4)
            {
                //Too many duplicate values were removed, there is no way there is a straight of 4 or more,
                //Reassign for clarity;
                numberOfValues = 0;
            }
            else if(copyOfDiceList.Count == 4)
            {
                //4 items in list, can only be a small straight
                //Total will add up to 3 if there are 3 sets of consecutive numbers

                if ((copyOfDiceList[0] == 1 && copyOfDiceList[1] == 2) || (copyOfDiceList[0] == 2 && copyOfDiceList[1] == 3) || (copyOfDiceList[0] == 3 && copyOfDiceList[1] == 4))
                {
                    //Small combos:
                    //(1,2),3,4
                    //(2,3),4,5
                    //(3,4),5,6
                    numberOfValues++;
                }

                if ((copyOfDiceList[1] == 2 && copyOfDiceList[2] == 3) || (copyOfDiceList[1] == 3 && copyOfDiceList[2] == 4) || (copyOfDiceList[1] == 4 && copyOfDiceList[2] == 5))
                {
                    //Small combos:
                    //1,(2,3),4
                    //2,(3,4),5
                    //3,(4,5),6
                    numberOfValues++;
                }

                if ((copyOfDiceList[2] == 3 && copyOfDiceList[3] == 4) || (copyOfDiceList[2] == 4 && copyOfDiceList[3] == 5) || (copyOfDiceList[2] == 5 && copyOfDiceList[3] == 6))
                {
                    //Small combos:
                    //1,2,(3,4)
                    //2,3,(4,5)
                    //3,4,(5,6)
                    numberOfValues++;
                }

            }
            else if (copyOfDiceList.Count >= 5)
            {
                //Already checked for a small straight so just for a large straight here
                //If a small stright ends up here it will still return 4 from this method
                //Total will add up to 4 sets of numbers

                if ((copyOfDiceList[0] == 1 && copyOfDiceList[1] == 2) || (copyOfDiceList[0] == 2 && copyOfDiceList[1] == 3))
                {
                    //Large Combos:
                    //(1,2),3,4,5
                    //(2,3),4,5,6
                    numberOfValues++;
                }

                if ((copyOfDiceList[1] == 2 && copyOfDiceList[2] == 3) || (copyOfDiceList[1] == 3 && copyOfDiceList[2] == 4))
                {
                    //Large Combos:
                    //1,(2,3),4,5
                    //2,(3,4),5,6
                    numberOfValues++;
                }

                if ((copyOfDiceList[2] == 3 && copyOfDiceList[3] == 4) || (copyOfDiceList[2] == 4 && copyOfDiceList[3] == 5))
                {
                    //Large Combos:
                    //1,2,(3,4),5
                    //2,3,(4,5),6
                    numberOfValues++;
                }

                if ((copyOfDiceList[3] == 4 && copyOfDiceList[4] == 5) || (copyOfDiceList[3] == 5 && copyOfDiceList[4] == 6))
                {
                    //Large Combos:
                    //1,2,3,(4,5)
                    //2,3,4,(5,6)
                    numberOfValues++;
                }
            }

            numberOfValues++; //Since this returns the number of values, not number of pairs, and we only care if it's above 4 anyway
            return numberOfValues;
        }

        private bool doesFullHouseExist()
        {
            //Similar to the number of idential values method
            bool fullHouse = false;
            bool twoHousePart = false;
            bool threeHousePart = false;

            //These are the values on the dice
            int one = 0;
            int two = 0;
            int three = 0;
            int four = 0;
            int five = 0;
            int six = 0;

            List<int> numberOfValues = new List<int>();

            for (int i = 0; i < 5; i++)
            {
                //Count the number of times each number shows up
                if (diceList[i] == 1)
                {
                    one++;
                }
                else if (diceList[i] == 2)
                {
                    two++;
                }
                else if (diceList[i] == 3)
                {
                    three++;
                }
                else if (diceList[i] == 4)
                {
                    four++;
                }
                else if (diceList[i] == 5)
                {
                    five++;
                }
                else if (diceList[i] == 6)
                {
                    six++;
                }
            }

            numberOfValues.Add(one);
            numberOfValues.Add(two);
            numberOfValues.Add(three);
            numberOfValues.Add(four);
            numberOfValues.Add(five);
            numberOfValues.Add(six);

            for (int i = 0; i < 6; i++)
            {
                if(numberOfValues[i] == 2)
                {
                    twoHousePart = true;
                }

                if(numberOfValues[i] == 3)
                {
                    threeHousePart = true;
                }
            }

            if(twoHousePart == true && threeHousePart == true)
            {
                fullHouse = true;
            }

            return fullHouse;
        }
    }
}

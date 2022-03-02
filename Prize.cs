using System;
using System.Collections.Generic;


namespace Quest
{
    public class Prize
    {   
        //phase 6
            private string _text;
            // need to make a constructor to pass the prize 
            public Prize(string text)
            {
                _text=text;
            }

            public void ShowPrize(Adventurer adventurer)
            {   
                if(adventurer.Awesomeness > 0){
                    Console.WriteLine(_text);
                }
                else if (adventurer.Awesomeness<=0){
                    Console.WriteLine("Your adventurer is not very cash money of you.");
                }
            }

    }

}
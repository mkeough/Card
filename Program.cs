using System;
using System.Collections.Generic;

namespace Card
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("lets play cards");
      //create a new empty deck
      var newDeck = new List<string>();
      //shuffled deck
      var shuffledDeck = new List<string>(); 
      //splitting up rnaks and suit into strings
      var suits = new List<string>() { "Clubs", "Hearts", "Spades", "Diamond" };
      var ranks = new List<string>() {"two", "three", "four", "five", "six",
      "seven", "eight", "nine", "ten", "jack", "queen" ,"king", "ace"};
      //looping deck

      for (var i = 0; i < suits.Count; i++) {
       for (var q = 0; q < ranks.Count; q++)

        {
          // add the card to the new deck
          // Console.WriteLine($"{Ranks[q]} of {Suits[i]}");
          newDeck.Add($"{ranks[q]} of {suits[i]}");

          //newDeck[0] = "two of clubs"
        } 
      }
      //while variable newdeck has 52 cards in it,
      // removing/adding card from/to decks until theres 0/52 cards
      while (newDeck.Count > 0 )      {
      // //Shuffle deck, genorate random algorithm
       Random rnd = new Random();
        var j = rnd.Next(newDeck.Count);
        var selectedCard = newDeck[j];
        //removing card from newDeck
        //adding to newnewdeck
        newDeck.Remove(selectedCard);
        shuffledDeck.Add(selectedCard);
     
      }
       //displaying top card
        Console.WriteLine(shuffledDeck[0]); 
      // Give the user an option to see the next card or quit the program.
        Console.WriteLine("would you like to see the next card 'y' or 'n'"); 
        var userChoice = Console.ReadLine().ToLower();
        if (userChoice == "y")
          {Console.WriteLine(shuffledDeck[1]);}
        if (userChoice == "no")
          {return;}
          

        
    

     
      // //for (var i=51; i >= 1; i--); 
      
     }
   }

 }








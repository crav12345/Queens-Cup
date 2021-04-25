﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rules : MonoBehaviour
{
    #region Variables
    [Header("Rules")]
    public static string[] twos = new string[] {
        "Double Double:\nNext person to draw 2 must must drink twice.",
        "Pants on Fire:\nPlay one round of two truths and a lie. If the lie is found, you drink. If a truth is picked, the rest of the group drinks."
    };

    public static string[] threes = new string[] {
        "Drink for free:\nTake one of someone else’s drinks.",
        "Drink for me:\nPick a friend to drink for you for your next turn so you don’t have to!",
        "Snaps:\nEveryone snaps their fingers three times, last one drinks."
    };

    public static string[] fours = new string[] {
        "Leap frog:\nLeap frog race with a parent against two others from one side of the room to another.  Losing team drinks.",
        "Voltage:\nRace to turn of the lights. The winner does not drink, the rest do."
    };

    public static string[] fives = new string[] {
       "Copycat:\nPick a person. That person drinks every time you drink for 9 turns, or until copycat is drawn again."
    };

    public static string[] sixes = new string[] {
        "Breakdown:\nSlap yourself in the face and drink."
    };
    
    public static string[] sevens = new string[] {
        "Skydive:\nEveryone raises one hand into the air.  Continue play.  The first person to lower their hand drinks."
    };
    
    public static string[] eights = new string[] {
        "Guardian:\nPick a person other than yourself.  That person is protected from having to drink once."
    };
    
    public static string[] nines = new string[] {
        "Jinx:\nEveryone knocks on a wooden surface.  The last to knock drinks."
    };

    public static string[] tens = new string[] {
        "Hollywood:\nName a movie genre.  Everyone takes turns listing movies in that genre.  If a person can't name a movie in 3 seconds, they drink."
    };
    
    public static string[] jacks = new string[] {
        "Takeout:\nPick a person. Play Chopsticks. Loser drinks."
    };
    
    public static string[] queens = new string[] {
        "Outlier:\nEveryone but you drinks.",
        "Resurrection:\nBring a player back into the game."
    };
    
    public static string[] kings = new string[] {
        "Draw!:\n Draw another card and do that rule twice.",
        "Father and Son:\nChoose a prince to drink with you until another king is drawn."
    };

    public static string[] aces = new string[] {
        "Compliments to the Chef:\nCompliment someone aggressively until you can’t think of a compliment or you laugh.  Don’t repeat compliments.",
        "Alphabet:\nsay a word starting with “A” - “Z”, if you’re can’t think of a word drink "
    };

    public static string[] jokers = new string[] {
        "Society:\nDrink the beverage in the middle of the table, replace it with a new one, and you’re out of the game, congratulations!"
    };

    [Header("Choices")]
    int choice;
    public string[][] choices = new string[][] { twos, threes, fours, fives, sixes, sevens, eights, nines, tens, jacks, kings, queens, aces};
    #endregion

    /// <summary>
    /// Grabs a random rule by the index
    /// </summary>
    /// <param name="i"></param>
    /// <returns></returns>
    public string GetRule(int i)
    {
        choice = Random.Range(0, choices[i - 2].Length);
        return choices[i - 2][choice];
    }
}

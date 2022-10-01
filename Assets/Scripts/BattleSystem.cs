using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This class holds all the logic for our battle system, so being able to calculate the percentage chance of us winning.
/// As well as determine which of the two characters has won a fight, or if it's a draw
/// </summary>
public class BattleSystem : MonoBehaviour
{
    private void Start()
    {
        // let's start by setting our player dancing stats to random numbers
        // style should be random between 1-10
        int playerOneStyle = 0;
        // luck should be random between 0-4
        int playerOneLuck = 0;
        // ryhtm should be random between 1-6
        int playerOneRyhtm = 0;
        // style should be random between 1-10
        int playerTwoStyle = 0;
        // luck should be random between 0-4
        int playerTwoLuck = 0;
        // ryhtm should be random between 1-6
        int playerTwoRyhtm = 0;

        // let's set our player power levels, using an algorithm, the simpliest would be luck + style + rhythm
        // this algorthim should be the same for each character to keep it fair.
        int playerOnePowerLevel = 0;
        int playerTwoPowerLevel = 0;

        // Debug out the two players, power levels.

        // calculate the percentage chance of winning the fight for each character.
        // todo this you'll need to add the two powers together, then divide you characters power against this and multiply the result by 100.
        int totalPower = 0;
        int playerOneChanceToWin = 0;
        int playerTwoChanceToWin = 0;

        // Debug out the chance of each character to win.

        // We probably want to compare the powers of our characters and decide who has a higher power level; I just hope they aren't over 9000.  

            // Debug out which character has won, which has lost, or if it's a draw. 
            // Debug out how much experience they should gain based on the difference of their chances to win, or if it's a draw award a default amount.
    }
}

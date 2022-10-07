using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This class holds all the logic for our battle system, so being able to calculate the percentage chance of us winning.
/// As well as determine which of the two characters has won a fight, or if it's a draw
/// </summary>
public class BattleSystem : MonoBehaviour
{
    #region Public Functions
    // all of my public variables are held here, these will be used to dictate the power levels between players to calculate the winner.
    public int playerOneAgility = 0;
    public int playerOneIntelligence = 0;
    public int playerOneStrength = 0;
    public int playerOnePowerLevel = 0;

    public int playerTwoAgility = 0;
    public int playerTwoIntelligence = 0;
    public int playerTwoStrength = 0;
    public int playerTwoPowerLevel = 0;

    public int playerOneStyle = 0;
    public int playerOneLuck = 0;
    public int playerOneRhythm = 0;

    public int playerTwoStyle = 0;
    public int playerTwoLuck = 0;
    public int playerTwoRhythm = 0;

    #endregion
    private void Start()
    {
        /// Summary of random range.
        /// Here we have used a random range of 10 points to allocate values to the dancing stats to each player.
        /// This hasn't been mulitplied from their original power levels as we wanted to calculate a random number and not a predetermined number.
        ///
        #region RandomRange.
        // let's start by setting our player dancing stats to random numbers
        
        

        int randomRange = 11;

        // style should be random between 1-10
        int playerOneStyle = Random.Range(1,randomRange);
        randomRange = (playerOneStyle - randomRange);

        // ryhtm should be random between 1-what is left over
        int playerOneRyhtm = Random.Range(1,randomRange);
        randomRange = (playerOneRyhtm - randomRange);

        // luck should be random between 1-what is left over
        int playerOneLuck = Random.Range(1, randomRange);
        randomRange = (playerOneLuck - randomRange);


        int randomRangeNew = 11;

        // style should be random between 1-10
        int playerTwoStyle = Random.Range(1, randomRangeNew);
        randomRangeNew = (playerTwoStyle - randomRangeNew);

        // ryhtm should be random between 1-what is left over
        int playerTwoRyhtm = Random.Range(1, randomRangeNew);
        randomRangeNew = (playerTwoRyhtm - randomRangeNew);

        // luck should be random between 1-what is left over
        int playerTwoLuck = Random.Range(1, randomRangeNew);
        randomRangeNew = (playerTwoLuck - randomRangeNew);

        Debug.Log(playerOneStyle + " -is my style level, " + playerTwoStyle + "-is player twos style level," +
              playerOneLuck + "-is my luck level, " + playerTwoLuck + "-is player twos luck level," +
              playerOneRhythm + "-is my rhythm level, " + playerTwoRhythm + "-is player twos rhythm level"); 

        #endregion 

        /// Summary of Power level compariosns
        /// Here is the calculations of each players power levels and the deciding factors of who wins based on percentages.
        /// 
        #region Power Level Comparisons
        // let's set our player power levels, using an algorithm, the simpliest would be luck + style + rhythm
        // this algorthim should be the same for each character to keep it fair.

        playerOnePowerLevel = (playerOneStyle + playerOneRyhtm + playerOneLuck);

        Debug.Log(playerOnePowerLevel + " is my power level. " );

        playerTwoPowerLevel = (playerTwoStyle + playerTwoRyhtm + playerTwoLuck);

        Debug.Log(playerTwoPowerLevel + " is player two's power level ");

        // calculate the percentage chance of winning the fight for each character.
        // to do this you'll need to add the two powers together, then divide you characters power against this and multiply the result by 100.
        int totalPower = (playerOnePowerLevel + playerTwoPowerLevel);
        int playerOneChanceToWin = (playerOnePowerLevel / totalPower) * 100;
        int playerTwoChanceToWin = (playerTwoPowerLevel / totalPower) * 100;

        // Debug out the chance of each character to win.

        Debug.Log(playerOneChanceToWin + "% - is my chance of winning, " +
            playerTwoChanceToWin + "% - is player two chance to win.");

        
        // We probably want to compare the powers of our characters and decide who has a higher power level; I just hope they aren't over 9000.  
        
        string PlayerOne = "PlayerOne";
        string PlayerTwo = "PlayerTwo";

        if (playerOnePowerLevel > playerTwoPowerLevel)
        {
             Debug.Log(PlayerOne + "has a higher power level of " + playerOneChanceToWin + "%");
        }

       else if (playerTwoPowerLevel > playerOnePowerLevel)
        {
            Debug.Log(PlayerTwo + "has a higher power level of " + playerTwoChanceToWin + "%");
        }
        
        else
        {
            Debug.Log(PlayerOne + " is equal too the same as " + PlayerTwo + " Everyone wins");
        }


        // Debug out how much experience they should gain based on the difference of their chances to win, or if it's a draw award a default amount.

        if (playerOnePowerLevel > playerTwoPowerLevel) // if player one has greater power level then player one wins and recieves 10Xp + %xp bonus on win e.g. 10Xp + 20% bonus = 12Xp
        {
            Debug.Log(PlayerOne + " recieve 10Xp + " + playerOneChanceToWin + "% bonus");
        }

        else if (playerOnePowerLevel < playerTwoPowerLevel) // if player two has greater power level then player two win and recieves 10 Xp +%xp bonus on win.
        {
            Debug.Log(PlayerTwo + " recieve 10Xp + " + playerTwoChanceToWin + "% bonus");
        }

        else // if both player have the same power level then it is a draw and they both recieve 10Xp.
        {
            Debug.Log(PlayerTwo + PlayerOne + " have drawed both recieve 10Xp ");
        }
        #endregion
    }
}

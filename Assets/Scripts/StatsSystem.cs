using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This class holds all the logic for our stats system, so that includes logic to handle generating starting physical stats
/// calculating our dancing stats based on physical stats and our stat multipliers.
/// </summary>
public class StatsSystem : MonoBehaviour
{
    #region Variables are stored here...
    /// Our physical stats that determine our dancing stats.
    public int playerOneAgility = 0;
    public int playerOneIntelligence = 0;
    public int playerOneStrength = 0;
    public int playerOnePowerLevel = 0;

    public int playerTwoAgility = 0;
    public int playerTwoIntelligence = 0;
    public int playerTwoStrength = 0;
    public int playerTwoPowerLevel = 0;

    // Our variables used to determine our fighting power.
    public int playerOneStyle = 0;
    public int playerOneLuck = 0;
    public int playerOneRhythm = 0;

    public int playerTwoStyle = 0;
    public int playerTwoLuck = 0;
    public int playerTwoRhythm = 0;

    public bool doesWork = true;
    #endregion
    private void Start()
    {
        ///</summary>
        /// In here we show some alternate working out using Random.Range with out setting a statpool.
        ///</summary>
        #region Example of alternate working out...
        // set out agility, strength and intelligence to a random number between zero and ten.
        // We can find our Random value for each class with this style here but using the statpool provides more accurate results.
        /*
        *playerOneAgility = Random.Range(0, 11);
        *playerOneIntelligence = Random.Range(0, 11);
        *playerOneStrength = Random.Range(0, 11);
        *playerTwoAgility = Random.Range(0, 11);
        *playerTwoIntelligence = Random.Range(0, 11);
        *playerTwoStrength = Random.Range(0, 11);
        */

        #endregion

        ///</summary>
        ///In here shows the full calculation of how to find the players stat levels and how to set modifiers that will effect these stats to become dancing stats.
        ///</summary>
        #region Calculating Stats for players...
        // BONUS! let's try taking our stats away from a pool of stats, i.e. 20 total, distributing this amoungst all the stats.

        int statPool = 31;

        playerOneAgility = Random.Range(0, statPool);
        statPool = (playerOneAgility - statPool); // By taking away from the stat pool with the variable is was just used with, it changed value to a random number that will allow for the next variable to be allocated accurately.

         playerOneStrength = Random.Range(0, statPool);
        statPool = (playerOneStrength - statPool);

        playerOneIntelligence = Random.Range(0, statPool);
        statPool = (playerOneIntelligence - statPool);

        int statPoolTwo = 31;

        playerTwoAgility = Random.Range(0, statPoolTwo);
        statPoolTwo = (playerTwoAgility - statPoolTwo); 

        playerTwoStrength = Random.Range(0, statPoolTwo);
        statPoolTwo = (playerTwoStrength - statPoolTwo);

        playerTwoIntelligence = Random.Range(0, statPoolTwo);
        statPoolTwo = (playerTwoIntelligence - statPoolTwo);

        // Debug out your current physical stat values (strength, agility, intelligence).

        Debug.Log("My agility is : " + playerOneAgility +
            "My strength is: " + playerOneStrength +
            "My Intelligence is: " + playerOneIntelligence);

        Debug.Log("Player two agility is : " + playerTwoAgility +
            "Player two strength is: " + playerTwoStrength +
            "Player two Intelligence is: " + playerTwoIntelligence);
        
        

        // let's create some float temporary variables to hold our multiplier values.

        /* create an agility multiplier should be set to 0.5
         *create a strength multiplier should be set to 1
         *create an intelligence multiplier should be set to 1.5.
         */

        float agilMulti = 0.5f;
        float strMulti = 1.0f;
        float intelMutli = 1.5f;

        // Debug out our current multiplier values.
        Debug.Log(agilMulti + "is the current agility multiplier - " + 
            strMulti + "is the current strength multiplier - " + 
            intelMutli + "is the current intelligence multiplier - ");

        // now that we have some stats and our multiplier values let's calculate our style, luck and ryhtmn based on these values.

        // style should be based off our strength and be converted at a rate of 1 : 1.
        playerOneStyle = (int)(playerOneStrength * strMulti);
        playerTwoStyle = (int)(playerTwoStrength * strMulti);
        // luck should be based off our intelligence and be converted at a rate of 1 : 1.5f
        playerOneLuck = (int)(playerOneIntelligence * intelMutli);
        playerTwoLuck = (int)(playerTwoIntelligence * intelMutli);
        // rhythm should be based off our agility and be converted at a rate of 1 : 0.5.
        playerOneRhythm = (int)(playerOneAgility * agilMulti);
        playerTwoRhythm = (int)(playerTwoAgility * agilMulti);

        // Debug out our current dancing stat values (style, luck, rhythm)

        Debug.Log(playerOneStyle + " -is my style level, " + playerTwoStyle + "-is player twos style level," +
            playerOneLuck + "-is my luck level, " + playerTwoLuck + "-is player twos luck level," + 
            playerOneRhythm + "-is my rhythm level, " + playerTwoRhythm + "-is player twos rhythm level"); 
        

        // now let's imagine that our level has increased; and we've been granted 10 new stat points.
        // let's distribute those stats amoungst our strength and agility and intelligence.
        int additionalPoints = 10;
        playerOneStrength = (playerOneStrength + Random.Range(0, additionalPoints +1));
        playerOneAgility = (playerOneAgility + Random.Range(0, additionalPoints +1));
        playerOneIntelligence = (playerOneIntelligence + Random.Range(0, additionalPoints +1));

        // Debug out our new physical stat values
        Debug.Log("My agility is : " + playerOneAgility +
            "My strength is: " + playerOneStrength +
            "My Intelligence is: " + playerOneIntelligence);

        // let's recalculate our style, luck and rhythm as our initial stats have changed.
        
        playerOneStyle = (int)(playerOneStrength * strMulti);
        playerTwoStyle = (int)(playerTwoStrength * strMulti);
       
        playerOneLuck = (int)(playerOneIntelligence * intelMutli);
        playerTwoLuck = (int)(playerTwoIntelligence * intelMutli);
        
        playerOneRhythm = (int)(playerOneAgility * agilMulti);
        playerTwoRhythm = (int)(playerTwoAgility * agilMulti);

        // Debug out our new dancing stat values
        Debug.Log(playerOneStyle + " -is my style level, " + playerTwoStyle + "-is player twos style level," +
            playerOneLuck + "-is my luck level, " + playerTwoLuck + "-is player twos luck level," +
            playerOneRhythm + "-is my rhythm level, " + playerTwoRhythm + "-is player twos rhythm level");
        #endregion 
    }

}

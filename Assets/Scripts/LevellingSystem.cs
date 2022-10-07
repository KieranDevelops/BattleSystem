using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This class holds all the logic for our levelling system, so that includes logic to handle levelling up, gaining xp and detecting when we should level up!.
/// </summary>
public class LevellingSystem : MonoBehaviour
{
    #region Variables are stored here...
    public int currentLevel = 0; // Our current level.

    public int currentXp; // The current amount of xp we have accumulated.

    public int currentXPThreshold = 10; // The amount of xp required to level up.
    #endregion

    private void Start()
    {
        ///</summary> 
        ///All of the start values are set within in this region.
        ///</summary>
        #region Setting our values for start of game...
        // set our current level to one.

        currentLevel = currentLevel + 1; // we have added the addition of 1 to increase our level by only 1.

        // set our current XP to zero

        currentXp = 0;

        // set our current XP Threshold to be our level multiplied by our 100.

        currentXPThreshold = currentLevel * 100;

        Debug.Log("My current level is lvl: " + currentLevel +
            "My current Xp is at: " + currentXp + "Xp" +
            "The current Xp threshold is at: " + currentXPThreshold + "Xp");

        // Debug out our starting values of our level, xp and current xp threshold

        // Increase the current XP by one hundred.

        currentXp = (currentXp + 100);

        // Debug out our current XP.

        Debug.Log("My current xp is now at: " + currentXp);
        #endregion

        ///</summary>
        ///We mulitplied our values by each other and asked if the threshold had been excceeded and if so if it was time to level up the character and reset the Xp threshold.
        ///</summary>
        #region Asking question if we are ready to level up...
        // check if our current XP is more than our threshold.

        if (currentXp >= currentXPThreshold)
        {
            Debug.Log("Xp has reached Xp threshold - " + currentXp + "Xp is my current Xp, " + 
               currentXPThreshold + "is my current threshold");
        }

        // if it is, then let's increase out level by one.

        if (currentXp >= currentXPThreshold)
        {
            currentLevel = currentLevel + 1;
            Debug.Log("Xp has reached threshold of " + currentXPThreshold + "you have leveled up, you are now lvl: " + currentLevel);
        }

                // let's also increase recalculate our current xp threshold as we've levelled up.

        if (currentLevel >= 1)
        {
            currentXPThreshold = currentLevel * 100;

            Debug.Log("My new Xp threshold is now: " + currentXPThreshold + "Xp"); // Debug out our new level value, as well as our current XP and our next Threshold we need to hit.
        }
        #endregion

    }
}

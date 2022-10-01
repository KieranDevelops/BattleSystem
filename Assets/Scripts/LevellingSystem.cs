using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This class holds all the logic for our levelling system, so that includes logic to handle levelling up, gaining xp and detecting when we should level up!.
/// </summary>
public class LevellingSystem : MonoBehaviour
{
    public int curretLevel; // Our current level.

    public int currentXp; // The current amount of xp we have accumulated.

    public int currentXPThreshold = 10; // The amount of xp required to level up.

    private void Start()
    {
        // set our current level to one.

        // set our current XP to zero

        // set our current XP Threshold to be our level multiplied by our 100.
        
        // Debug out our starting values of our level, xp and current xp threshold

        // Increase the current XP by one hundred.

        // Debug out our current XP.

        // check if our current XP is more than our threshold.

                // if it is, then let's increase out level by one.
                // let's also increase recalculate our current xp threshold as we've levelled up.
                // Debug out our new level value, as well as our current XP and our next Threshold we need to hit.

    }
}

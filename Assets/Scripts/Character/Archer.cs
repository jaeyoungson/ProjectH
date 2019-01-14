using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Global_Define;

public class Archer : PlayableCharacter
{
    public ArcherState archerState;

    // Update is called once per frame
    void Update()
    {
        if (playingCharacter == false)
        {
            switch (archerState)
            {
                default:
                    break;
            }

        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Global_Define;

public class Mage : PlayableCharacter
{
    public MageState mageState;
    // Update is called once per frame
    void Update()
    {
        if (playingCharacter == false)
        {
            switch (mageState)
            {
                default:
                    break;
            }

        }
    }
}

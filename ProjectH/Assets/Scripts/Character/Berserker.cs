using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Global_Define;

public class Berserker : PlayableCharacter
{
    private BerserkerState berserkerState;

    public BerserkerState getBerserkerState
    {
        get { return berserkerState; }
    }

    public void SetBerserkerState(BerserkerState _berserkerState)
    {
        berserkerState = _berserkerState;
    }

    void Update()
    {
        if (playingCharacter == false)
        {
            switch (berserkerState)
            {
                default:
                    break;
            }

        }
    }
    



}

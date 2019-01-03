using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleManager : ManagerBase<BattleManager>
{
    public GameObject[] playerCharacters = new GameObject[3];
    public GameObject playingCharacter;

    private new void Awake()
    {
        playingCharacter = playerCharacters[0];
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Global_Define;
public class GameManager : ManagerBase<GameManager>
{

    [SerializeField]
    private GameObject[] userCharacter = new GameObject[3];
    private PlayCharacter jobState;
    public GameObject curPlayCharacter;
    public GameObject nextPlayCharcter;

    private new void Awake()
    {
        curPlayCharacter = userCharacter[(int)PlayCharacter.Warrior];
    }

    #region get

    public GameObject getCurPlayCharacter
    {
        get
        {
            return curPlayCharacter;
        }
    }
#endregion

#region set

#endregion
    private void Update()
    {
        if(nextPlayCharcter != null)
        {
            curPlayCharacter = nextPlayCharcter;
            nextPlayCharcter = null;
        }
    }

    public void ChangeCharacterJob()
    {
        if((int)jobState<2)
        {
            nextPlayCharcter = userCharacter[(int)jobState++];
            jobState++;
        }
        else
        {
            nextPlayCharcter = userCharacter[(int)PlayCharacter.Warrior];
            jobState = PlayCharacter.Warrior;
        }
    }
}

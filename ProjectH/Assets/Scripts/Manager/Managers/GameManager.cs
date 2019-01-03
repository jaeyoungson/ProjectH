using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Global_Define;
public class GameManager : ManagerBase<GameManager>
{

    [SerializeField]
    private GameObject[] userCharacter = new GameObject[3];
    public PlayCharacter jobState;
    public GameObject curPlayCharacter;
    public GameObject nextPlayCharcter;

    private new void Awake()
    {
        curPlayCharacter = userCharacter[(int)PlayCharacter.Warrior];
    }

    private void Start()
    {
        
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
    }

    public void ChangeCharacterJob()
    {
        if((int)jobState<2)
        {
            jobState++;
            curPlayCharacter = userCharacter[(int)jobState];           
        }
        else
        {
            curPlayCharacter = userCharacter[(int)PlayCharacter.Warrior];
            jobState = PlayCharacter.Warrior;
        }
    }
}

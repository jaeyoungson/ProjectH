using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Global_Define;

public class Archer : PlayableCharacter
{
    public ArcherState archerState;
    private float curCharge;
    [SerializeField]
    private float secondCharge;
    [SerializeField]
    private float maxCharge;
    
    
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

    public override void NormalSkill()
    {
        if(Input.GetKey(InputManager.Ins.normalAttack))
        {           
            if(curCharge-float.Epsilon<=maxCharge)
            {
                curCharge += Time.deltaTime;
                
            }
        }

        if(Input.GetKeyUp(InputManager.Ins.normalAttack))
        {
            if(curCharge-float.Epsilon<secondCharge)
            {
#if UNITY_EDITOR
                Debug.Log("Charge1");
                curCharge = 0;
#endif
            }
            else if(secondCharge<=curCharge&&curCharge<maxCharge)
            {
                Debug.Log("Charge2");
                curCharge = 0;
            }
            else
            {
                Debug.Log("Charge3");
                curCharge = 0;
            }

        }
    }
}

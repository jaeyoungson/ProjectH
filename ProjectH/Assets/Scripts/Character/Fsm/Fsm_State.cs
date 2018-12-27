using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public abstract class Fsm_State<Fsm_Type>
{
    private Fsm_Type stateType;

    public Fsm_State(Fsm_Type stateIndex)
    {
        stateType = stateIndex;
    }

    public Fsm_Type getStateType
    {
        get
        {
            return stateType;
        }
    }

    #region virtual
    public virtual void Enter()
    {

    }

    public virtual void Update()
    {

    }

    public virtual void End()
    {

    }
    #endregion
}

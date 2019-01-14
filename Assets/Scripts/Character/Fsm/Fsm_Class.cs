using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Fsm_Class<Fsm_Type>
{
    protected Dictionary<Fsm_Type, Fsm_State<Fsm_Type>> fsmStateList = new Dictionary<Fsm_Type, Fsm_State<Fsm_Type>>();
    protected Fsm_State<Fsm_Type> curState;     //현재스테이트
    protected Fsm_State<Fsm_Type> nextState;    //다음스테이트

    #region -get
    public Fsm_State<Fsm_Type> getcurState
    {
        get
        {
            return curState;
        }        
    }

    public Fsm_Type getCurStateType
    {
        get
        {
            if (curState == null)
                return default(Fsm_Type);
            return curState.getStateType;
        }
    }

    public Fsm_State<Fsm_Type> getNextState
    {
        get
        {
            return nextState;
        }
    }

    public Fsm_Type getNextStateType
    {
        get 
        {
            if (nextState == null)
                return default(Fsm_Type);
            return nextState.getStateType;
        }
    }
    #endregion

    #region virtual
    public virtual void Clear()
    {
        fsmStateList.Clear();
        curState = null;
        nextState = null;
    }

    public virtual void Init()
    {
        curState = null;
        nextState = null;
    }

    public virtual void AddFsm(Fsm_State<Fsm_Type> state)
    {
        fsmStateList.Add(state.getStateType, state);
    }

    public virtual void SetState(Fsm_Type state)
    {
        nextState = fsmStateList[state];
    }

    public virtual void Update()
    {
        if(null !=nextState)
        {
            if(null != curState)
            {
                curState.End();
            }

            curState = nextState;
            curState.Enter();
            nextState = null;
        }

        if(curState != null)
        {
            curState.Update();
        }
    }

    #endregion


}

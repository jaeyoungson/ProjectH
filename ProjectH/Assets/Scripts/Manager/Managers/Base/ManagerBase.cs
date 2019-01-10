using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerBase<T> : SingletonBase<T>
                                  where T : ManagerBase<T>
{
    protected new void Awake()
    {
        base.Awake();
        DontDestroyOnLoad(this);

    }
}

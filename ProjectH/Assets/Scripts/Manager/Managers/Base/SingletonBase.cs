using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonBase<T> : MonoBehaviour
                                where T: SingletonBase<T>
{
    static protected T instance = default;

    public static T Ins
    {
        get
        {
            if(instance ==null)
            {
                instance = FindObjectOfType<T>();                
            }

            return instance;
        }
    }

    protected void Awake()
    {
        if(instance == null)
        {
            instance = (T)this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
    }


}

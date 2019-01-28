using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Global_Define;
public class PoolManager : ManagerBase<PoolManager>
{
    public Dictionary<ObjectPool, PoolKinds> miniPools = new Dictionary<ObjectPool, PoolKinds>();

    private void Start()
    {
        PoolKinds[] addKinds = Object.FindObjectsOfType<PoolKinds>();
        for (int i = 0; i < addKinds.Length; i++)
        {
            miniPools.Add(addKinds[i].kinds, addKinds[i]);
        }
    }

    public PoolKinds GetMiniPools(int kindIndex)
    {
        if(miniPools.ContainsKey((ObjectPool)kindIndex))
        {
            return miniPools[(ObjectPool)kindIndex];
        }
        else
        {
            Debug.Log("Have not KindPool");
        }
        return null;           
    }

    public GameObject GetObject(int kindIndex,int miniPoolIndex)
    {
        if (miniPools.ContainsKey((ObjectPool)kindIndex))
        {
            return miniPools[(ObjectPool)kindIndex].GetObject(miniPoolIndex);
        }
        else
        {
            Debug.Log("Have not KindPool");
        }
        return null;
    }

}



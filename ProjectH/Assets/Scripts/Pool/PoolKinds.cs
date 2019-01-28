using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Global_Define;
public class PoolKinds : MonoBehaviour
{
    public List<MiniPool> miniPools;

    public ObjectPool kinds;

    public GameObject GetObject(int index)
    {
        return miniPools[index].GetObject();
    }
}

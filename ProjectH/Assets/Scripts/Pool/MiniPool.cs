using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniPool : MonoBehaviour
{
    public GameObject poolObject;
    public List<GameObject> poolObjectList = new List<GameObject>();
    public int count;

    private int useCount;

    private void Awake()
    {
        SetObject();
    }

    private void SetObject()
    {
        for(int i=0;i<count;i++)
        {
            GameObject newPoolObject = Instantiate(poolObject, gameObject.transform);
            newPoolObject.SetActive(false);
            poolObjectList.Add(newPoolObject);
        }
    }

    public GameObject GetObject()
    {
        for(int i=0; i<poolObjectList.Count;i++)
        {
            if(poolObjectList[i].activeInHierarchy==false)
            {
                return poolObjectList[i];
            }
        }

        SetObject();

        return GetObject();
    }   
}

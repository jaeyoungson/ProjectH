using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sentinel : PlayableCharacter
{
    private new void Awake()
    {
        animator = gameObject.GetComponent<Animator>(); 
    }

}

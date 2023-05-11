using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XLua;
[Hotfix]
public class EmptyScript01 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Gun.Instance.level = 3;
        EmptyMethod1();
        EmptyMethod();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnDisable()
    {
        
    }

    private void OnDestroy()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
       
    }

    void EmptyMethod()
    {
        
    }
    void EmptyMethod1()

    {
        
    }
}

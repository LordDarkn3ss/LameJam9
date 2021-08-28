using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoDell : MonoBehaviour
{
    [SerializeField]
    float timerToDell;
    void Start()
    {
        Destroy(this.gameObject,timerToDell);   
    }

    
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cleaner : MonoBehaviour
{
    [SerializeField]
    Animator vassoura;
    void Start()
    {

    }


    void Update()
    {
        
        if(Input.GetKey(KeyCode.X) || Input.GetKey(KeyCode.K))
        {
            vassoura.SetBool("Varrer", true);
        }
        else
        {
            vassoura.SetBool("Varrer", false);
        }
    }
}

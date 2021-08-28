using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    [SerializeField]
    Animator vassoura;
    void Start()
    {
        
    }

    
    void Update()
    {
        vassoura.SetBool("Attack", false);
        if (Input.GetKeyDown(KeyCode.Z) || Input.GetKeyDown(KeyCode.J))
        {
            vassoura.SetBool("Attack", true);
        }
    }
}

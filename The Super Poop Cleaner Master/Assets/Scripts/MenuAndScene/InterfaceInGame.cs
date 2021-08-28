using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterfaceInGame : MonoBehaviour
{
    public static bool paused = false;
    [SerializeField]
    Animator anim;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(ShitBarBehaviourScript.die)
        {
            anim.SetBool("Die", true);
        }
        if (!ShitBarBehaviourScript.die)
        {
            if(!paused)
            {
                anim.SetBool("Pause", false);
            }
            if (Input.GetKeyDown(KeyCode.P) && !paused)
            {
                Time.timeScale = 0;
                anim.SetBool("Pause", true);
                paused = true;
            }
            else if (Input.GetKeyDown(KeyCode.P) && paused)
            {
                Time.timeScale = 1;
                anim.SetBool("Pause", false);
                paused = false;
            }

            
        }
    }
}

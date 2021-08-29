using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class InterfaceInGame : MonoBehaviour
{
    public static bool paused = false;
    public static int score;
    [SerializeField]
    Text scoreTx;

    [SerializeField]
    Animator anim;
    void Awake()
    {
        score = 0;
        anim.SetBool("Die", false);
    }

    // Update is called once per frame
    void Update()
    {
        scoreTx.text = "Score: " +score.ToString(); //English


        if (ShitBarBehaviourScript.die)
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

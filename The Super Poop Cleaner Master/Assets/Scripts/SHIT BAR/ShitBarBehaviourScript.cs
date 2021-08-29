using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShitBarBehaviourScript : MonoBehaviour
{
    public static float shitBarNum, cleanerNum, shitedNum;
    [SerializeField]
    float cleanerNumStart,shitedNumStart;

   

    public static bool die;

    [SerializeField]
    Image shitBar;
    void Start() 
    {
        die = false;
        StartCoroutine(ConstantPoopBar(1f));


        shitedNum = shitedNumStart;
        cleanerNum = cleanerNumStart;
        shitBarNum = 0;
    }

    // Update is called once per frame
    void Update()
    {

        shitBar.fillAmount = shitBarNum/100;
        if (shitBarNum < 0) { shitBarNum = 0; }
        if (shitBar.fillAmount == 1) { die = true;}
    }
    public static void Shited()
    {
        shitBarNum += shitedNum;
    }

    public static void Cleaner()
    {
        shitBarNum -= cleanerNum;
    }



    IEnumerator ConstantPoopBar(float a)
    {
        while (true)
        {
            for (int i = 0; i < 4; i++)
            {
                yield return new WaitForSeconds(a);
                shitBarNum += 0.5f;
            }
            if (a > 0.2f) { a -= 0.01f; }
            
            
        }
            
       
        
    }
}

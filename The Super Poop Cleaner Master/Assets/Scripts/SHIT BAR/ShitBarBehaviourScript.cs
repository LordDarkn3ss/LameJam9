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

        StartCoroutine(ConstantPoopBar());


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



    IEnumerator ConstantPoopBar()
    {
        while (true)
        {
            yield return new WaitForSeconds(1f);
            shitBarNum += 0.5f;
        }
            
       
        
    }
}

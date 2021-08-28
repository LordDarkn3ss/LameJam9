using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShitBarBehaviourScript : MonoBehaviour
{
    public static float shitBarNum, cleanerNum, shitedNum;
    [SerializeField]
    float cleanerNumStart,shitedNumStart;

    [SerializeField]
    Image shitBar;
    void Start() 
    {
        shitedNum = shitedNumStart;
        cleanerNum = cleanerNumStart;
        shitBarNum = 30;
    }

    // Update is called once per frame
    void Update()
    {
        shitBar.fillAmount = shitBarNum/100;
        if (shitBarNum < 0) { shitBarNum = 0; }
    }
    public static void Shited()
    {
        shitBarNum += shitedNum;
    }

    public static void Cleaner()
    {
        shitBarNum -= cleanerNum;
    }
}

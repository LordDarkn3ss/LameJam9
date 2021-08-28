using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PoopLife : MonoBehaviour
{
    [SerializeField]
    Image life;
    
    void Awake()
    {
        life.fillAmount = 1f;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "VassouraHitBox")
        {
            life.fillAmount -= 0.33f;
            if (life.fillAmount <= 0.03f)
            {
                ShitBarBehaviourScript.Cleaner();
                Destroy(this.gameObject);
            }
        }
    }

}

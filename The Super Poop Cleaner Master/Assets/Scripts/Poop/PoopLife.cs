using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PoopLife : MonoBehaviour
{

    [SerializeField]
    GameObject powerUp;
    [SerializeField]
    Image life;
    [SerializeField]
    ParticleSystem poopExplosion;
    [SerializeField]
    int chanceSpawn;
    
    void Awake()
    {
        life.fillAmount = 1f;
    }

    void Update()
    {
        
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "VassouraHitBox")
        {
            InterfaceInGame.score += 5;
            life.fillAmount -= 0.33f;
            if (life.fillAmount <= 0.03f)
            {
                InterfaceInGame.score += 25;
                ShitBarBehaviourScript.Cleaner();

                Randomic();
                Destroy(this.gameObject);
            }
        }
        if (other.gameObject.tag == "Limpeza")
        {
            ShitBarBehaviourScript.shitBarNum -= 0.4f;
            InterfaceInGame.score += 5;
            life.fillAmount -= 0.10f;
            if (life.fillAmount <= 0.03f)
            {
                InterfaceInGame.score += 25;
                ShitBarBehaviourScript.Cleaner();

                Randomic();
                Destroy(this.gameObject);
            }
        }
        if (other.gameObject.tag == "Master")
        {
            Instantiate(poopExplosion, transform.position, Quaternion.identity);
                ShitBarBehaviourScript.Shited();
                Destroy(this.gameObject,0.1f);
            
        }
        if (other.gameObject.tag == "Explosion")
        {
            life.fillAmount -= 1f;
            if (life.fillAmount <= 0.03f)
            {
                InterfaceInGame.score += 25;
                ShitBarBehaviourScript.Cleaner();

                Randomic();
                
                Destroy(this.gameObject);
            }
        }

        void Randomic()
        {
            if (Random.Range(1, chanceSpawn +1) == chanceSpawn)
            {
                Instantiate(powerUp, transform.position, Quaternion.identity);
            }
        }
    }

}

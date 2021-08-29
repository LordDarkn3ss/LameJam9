using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerUp : MonoBehaviour
{
    [SerializeField]
    Image cleanerBar;
    [SerializeField]
    GameObject explosion;
    void Start()
    {
        cleanerBar.fillAmount = 1;
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Limpeza")
        {
            print("Totoro");
            InterfaceInGame.score += 1;
            cleanerBar.fillAmount -= 0.05f;
            if (cleanerBar.fillAmount <= 0.03f)
            {
                Instantiate(explosion, transform.position, Quaternion.identity);
                Destroy(this.gameObject);
            }
        }
    }
}

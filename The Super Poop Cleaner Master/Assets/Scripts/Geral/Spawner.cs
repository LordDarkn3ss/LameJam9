using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    Transform sR, sL;
    [SerializeField]
    GameObject poop;

    [SerializeField]
    float TimerSpawnFrequency;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(TimerToSpawn());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnR()
    {
        Instantiate(poop, sR.position, Quaternion.identity);
    }
    void SpawnL()
    {
        Instantiate(poop, sL.position, Quaternion.identity);
    }

    IEnumerator TimerToSpawn()
    {
        while (true)
        {
            for (int i = 0; i < 4; i++)
            {
                yield return new WaitForSeconds(TimerSpawnFrequency);
                SpawnL();
                SpawnR();
            }
            TimerSpawnFrequency -= 0.5f;
        }
    }
}

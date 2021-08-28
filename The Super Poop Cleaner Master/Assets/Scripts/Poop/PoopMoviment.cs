using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoopMoviment : MonoBehaviour
{
    [SerializeField]
    float speed;
    [HideInInspector]
    GameObject player;
    // Start is called before the first frame update
    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, new Vector2(player.transform.position.x, player.transform.position.y), speed * Time.deltaTime);
    }
}

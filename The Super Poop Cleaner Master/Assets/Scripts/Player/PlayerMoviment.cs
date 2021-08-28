using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoviment : MonoBehaviour
{
    [SerializeField]
    float speed, jumpForce, checkGround;
    [SerializeField]
    Transform groundDetect;
    [SerializeField]
    LayerMask piso;
    float eixoH;



    void Start()
    {

    }


    void Update()
    {

        Move();

    }

    void Move()
    {
        eixoH = Input.GetAxis("Horizontal");

        transform.Translate(Vector2.right * eixoH * speed * Time.deltaTime, 0);

        Debug.DrawRay(groundDetect.position, new Vector2(0, -checkGround), Color.red);
        if(Physics2D.Raycast(groundDetect.position, -groundDetect.up, checkGround, piso.value))
        {
            print("tocando o chão");
            if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
            {
                GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpForce));
            }
        }
    }
}

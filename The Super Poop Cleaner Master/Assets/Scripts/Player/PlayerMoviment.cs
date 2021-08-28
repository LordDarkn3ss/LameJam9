using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoviment : MonoBehaviour
{
    [SerializeField]
    Animator spin; //depois eu vejo isso
    [SerializeField]
    float speed, rotateSpeed, jumpForce, checkGround;
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
        Invert();
    }
        
    void Move()
    {
        eixoH = Input.GetAxis("Horizontal");

        transform.Translate(Vector2.right * eixoH * speed * Time.deltaTime, 0);

        Debug.DrawRay(groundDetect.position, new Vector2(0, -checkGround), Color.red);
        if(Physics2D.Raycast(groundDetect.position, -groundDetect.up, checkGround, piso.value))
        {
            if(!Input.GetKey(KeyCode.X) && !Input.GetKey(KeyCode.K))
            if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
            {
                GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpForce));
            }
        }
    }

    void Invert()
    {
        if (eixoH > 0){ transform.eulerAngles = new Vector2(0, 180); /*spin.SetBool("Girar", true);*/ }
        else if(eixoH < 0) { transform.eulerAngles = new Vector2(0, 0); /*spin.SetBool("Girar", true);*/ }
    }

}

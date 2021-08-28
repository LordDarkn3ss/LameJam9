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

    [SerializeField]
    Transform limiteMenor, limiteMaior;

    



    void Start()
    {

    }


    void Update()
    {

        Move();
        Limited();
        Invert();
    
        
            
    }
        
    void Move()
    {
        eixoH = Input.GetAxis("Horizontal");

        transform.Translate(Vector2.right * eixoH * speed * Time.deltaTime, 0);
        

        Debug.DrawRay(groundDetect.position, new Vector2(0, -checkGround), Color.red);
        if(Physics2D.Raycast(groundDetect.position, -groundDetect.up, checkGround, piso.value))
        {
            spin.SetBool("Jump", false);
            if (!Input.GetKey(KeyCode.X) && !Input.GetKey(KeyCode.K))
            if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
            {
                    spin.SetBool("Jump", true);
                GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpForce));
            }
        }
    }

    void Invert()
    {
        if (!spin.GetCurrentAnimatorStateInfo(0).IsName("VassouraAttack") &&
    !spin.GetCurrentAnimatorStateInfo(0).IsName("Varrer") &&
    !spin.GetCurrentAnimatorStateInfo(0).IsName("Varrendo") &&
    !spin.GetCurrentAnimatorStateInfo(0).IsName("RetornarIdle"))
        {
            if (eixoH > 0) { transform.eulerAngles = new Vector2(0, 180); /*spin.SetBool("Girar", true);*/ }
            else if (eixoH < 0) { transform.eulerAngles = new Vector2(0, 0); /*spin.SetBool("Girar", true);*/ }
        }
    }

    void Limited()
    {
        if (transform.position.x > limiteMaior.position.x)
        {
            transform.position = new Vector2(limiteMaior.position.x, transform.position.y);
        }
        else if (transform.position.x < limiteMenor.position.x)
        {
            transform.position = new Vector2(limiteMenor.position.x, transform.position.y);
        }
    }

}

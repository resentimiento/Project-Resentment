using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 3;
    public float jumpForce = 10 ;

    private float movX;
    private float movY;

    private bool facingRight = true;
    private bool isGrounded = false;

    private Rigidbody2D rb;
    private Animator _animator;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        /** Asignación de Movimiento en Horizontal **/
        movX = Input.GetAxis("Horizontal")*speed;
        movY = Input.GetAxis("Vertical");

        rb.velocity = new Vector2(movX, rb.velocity.y);


        /** Condicion IF de SALTAR con espacio **/
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {

            rb.AddForce(Vector2.up * jumpForce);
            /** Condicion IF de SALTAR con espacio **/
            _animator.SetTrigger("jump");
        }

        if (movX > 0 && !facingRight)
        {
            Flip();
        }
        if (movX < 0 && facingRight)
        {
            Flip();
        }

        /** Asignar Animación de Movimiento en X **/
        _animator.SetFloat("velocityX", Mathf.Abs(movX));
        _animator.SetFloat("velocityY", rb.velocity.y);
        _animator.SetBool("grounded", isGrounded);

    }

    void Flip()
    {
        Vector3 currentScale = transform.localScale;
        currentScale.x *= -1;
        transform.localScale = currentScale;

        facingRight = !facingRight;
    }


    private void OnCollisionEnter2D(Collision2D other)
    {

        if (other.gameObject.layer == 6)
        {
            isGrounded = true;
        }

    }

    private void OnCollisionExit2D(Collision2D other)
    {
        

        if(other.gameObject.layer == 6) 
        {
            isGrounded = false;
        }


    }

}

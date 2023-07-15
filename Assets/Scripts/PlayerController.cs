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
    private bool isGrounded;
    public Transform feetPos;
    public float checkRadius;
    public LayerMask whatIsGround;

    private Rigidbody2D rb;
    private Animator _animator;

    private float jumpTimeCounter;
    public float jumpTime;
    private bool isJumping;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
    }




    // Update is called once per frame
    void Update()
    {
        /** Asignaci�n de Movimiento en Horizontal **/
        movX = Input.GetAxis("Horizontal")*speed;
        movY = Input.GetAxis("Vertical");
        rb.velocity = new Vector2(movX, rb.velocity.y);





        // Condicion IF de SALTAR con flecha hacia arriba
        /** if (Input.GetKeyDown(KeyCode.UpArrow))
         {
             rb.AddForce(Vector2.up * jumpForce);
             // activa la animacion de salto 
             _animator.SetTrigger("jump");
     } **/





        /** Condicion IF de SALTAR con flecha hacia arriba **/
        isGrounded = Physics2D.OverlapCircle(feetPos.position, checkRadius, whatIsGround);

        if (isGrounded == true && Input.GetKeyDown(KeyCode.Space)){
            isJumping = true;
            jumpTimeCounter = jumpTime;
            rb.AddForce(Vector2.up * jumpForce);
            // activa la animacion de salto
            _animator.SetTrigger("jump");
        }


        if (Input.GetKey(KeyCode.Space) && isJumping == true){

            if (jumpTimeCounter > 0)
            {
                rb.AddForce(Vector2.up * jumpForce);
                jumpTimeCounter -= Time.deltaTime;
            }
            else
            {
                isJumping = false;
            }
        }

        if (Input.GetKeyUp(KeyCode.Space)){
            isJumping = false; 
        }


        /** Condicion IF de si el jugador mira a la izquierda o derecha **/
        if (movX > 0 && !facingRight){
            Flip();
        }
        /** Condicion IF de si el jugador mira a la izquierda o derecha **/
        if (movX < 0 && facingRight)
        {
            Flip();
        }

        /** Asignar Animaci�n de Movimiento en X **/
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

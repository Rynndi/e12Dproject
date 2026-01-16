using UnityEngine;
//import input system 
using UnityEngine.InputSystem;
public class newScript : MonoBehaviour
{
        // Start is called once before the first execution of Update after the MonoBehaviour is created
    float movementX;
    float movementY;
    [SerializeField] float speed = 5.0f; 
    Rigidbody2D rb; 
    bool isGrounded = false;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); 
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMove(InputValue value) { 
        //first part of vector 2 is value you're moving it to 
        //+1 is to right, -1 to left
        Vector2 v = value.Get<Vector2>(); 
        movementX = v.x; 
        movementY = v.y; 
        Debug.Log("Movement X = " + movementX);
        Debug.Log("Movement Y = " + movementY);
        //want to be able to make distance every tick 



    }
    //moves according to tick assigned in serialized field 
    void FixedUpdate() { 
        //because global, can take from any function 
        // float movementDistanceX = movementX * speed * Time.deltaTime; 
        // float movementDistanceY = movementY * speed * Time.deltaTime; 
        // transform.position = new Vector2(transform.position.x + movementDistanceX, transform.position.y + movementDistanceY);
        // rb.linearVelocity = new Vector2(movementX * speed, movementY * speed); 
        rb.linearVelocity = new Vector2(movementX * speed, rb.linearVelocity.y);
        if (movementY > 0 && isGrounded)
        { 
            rb.AddForce(new Vector2(0,100)); 
        }
    
    }
    private void OnCollisionEnter2D(Collision2D collision) { 
        if (collision.gameObject.CompareTag("Ground")) { 
            isGrounded = true; 
        }
    }

    private void OnCollisionExit2D(Collision2D collision) { 
        if (collision.gameObject.CompareTag("Ground")) { 
            isGrounded = false; 
        }
    }
}

using UnityEngine;


public class BouncyBall : MonoBehaviour
{
    //store rigidbody for circle 
    Rigidbody2D rb; 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //grabs rigidbody 2d, assigns it to rigidbody variable 
        rb = GetComponent<Rigidbody2D>(); 
        //want the ball to bounce when it hits the platform 


        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //call whenever collides with something 
    private void OnCollisionEnter2D(Collision2D collision){ 
        //up direction
        rb.AddForce(new Vector2(0, 500));


    }
}

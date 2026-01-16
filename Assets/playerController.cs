using UnityEngine;
//import input system 
using UnityEngine.InputSystem;
public class newScript : MonoBehaviour
{
        // Start is called once before the first execution of Update after the MonoBehaviour is created
    float movementX;
    float movementY;
    [SerializeField] float speed = 5.0f; 
    void Start()
    {
        
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
        float movementDistanceX = movementX * speed * Time.deltaTime; 
        float movementDistanceY = movementY * speed * Time.deltaTime; 
        transform.position = new Vector2(transform.position.x + movementDistanceX, transform.position.y + movementDistanceY);
    
    }
}

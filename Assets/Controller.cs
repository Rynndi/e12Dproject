using UnityEngine;
using Pathfinding; 


public class Controller : MonoBehaviour
{

    [SerializeField] Transform goal;
    AILerp aI;  

    void Start()
    {
        aI = GetComponent<AILerp>();
        
    }

    // Update is called once per frame
    void Update()
    {
        aI.destination = goal.position; 
        
    }
}

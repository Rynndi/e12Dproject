using UnityEngine;
using System.Collections; 


public class FlagPole : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] private float startPoint; 
    [SerializeField] private float endPoint; 
    private float interp = 0f; 
    //returns value between startpoint and endpoint 
    [SerializeField] GameObject flag; 

    //use flag to go to next scene (like in mario) 
    [SerializeField] NewSceneLoader sceneLoader; 
    void Start()
    {
        
    }
    //if collide with player, lower the flag 
    private void OnTriggerEnter2D(Collider2D other) { 
        if(other.gameObject.tag== "Player") { 
            StartCoroutine(LowerFlag()); 
        }
    }

    IEnumerator LowerFlag() { 
        //how much time has passed 
        while (interp < 1.0f) { 
            interp += Time.deltaTime;
            flag.transform.position = 
                new Vector3(flag.transform.position.x, 
                Mathf.Lerp(startPoint, endPoint, interp), 
                flag.transform.position.z); 
            yield return null; 
        } 
        sceneLoader.LoadScene();
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutofBounds : MonoBehaviour
{
    private float boundary = 20.0f;
    private float center = 10.0f; //center of visible part of the scene
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if((transform.position.z>(center+boundary))||(transform.position.z<(center-boundary))){
            if(transform.position.z<(center-boundary)) Debug.Log("Game Over!");//send message to console that game is over if animals reached the lower boundary
            Destroy(gameObject);
        }
    }
}

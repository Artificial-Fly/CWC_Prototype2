using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject projectilePrefab;
    private float horizontalInput;
    private float speed = 13.5f;
    private float boundary = 10.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //moving player left/right
        horizontalInput = Input.GetAxis("Horizontal");//get input
        if((transform.position.x < boundary && transform.position.x > -boundary)){//move if player is with boundaries
            transform.Translate(Vector3.right*horizontalInput*Time.deltaTime*speed);
        }else if((!(transform.position.x < boundary)&&(horizontalInput<0))||(!(transform.position.x > -boundary)&&(horizontalInput>0))){//move if player is returning with boundaries
            transform.Translate(Vector3.right*horizontalInput*Time.deltaTime*speed);
        }
        //shoting projectile on space-bar key
        if(Input.GetKeyDown(KeyCode.Space)){
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);//spawning projectile
        }
        
    }
}

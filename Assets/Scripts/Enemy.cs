using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float rotationSpeed;
    //dust
    public GameObject dust;

    private void FixedUpdate()
    {
        transform.Rotate(0,0,rotationSpeed);
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Destroy(collision.gameObject);
        }
    
        else if(collision.gameObject.tag == "Ground")
        {   
            gameObject.SetActive(false);
            //dust at position of spike collision
            GameObject dustEffect = Instantiate(dust,transform.position,Quaternion.identity);
            //destroys dust effect after short time
            
            Destroy(dustEffect, 2f);
            
            Destroy(gameObject, 3f);
        }
    
    }


}
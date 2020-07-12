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

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Destroy(collision.gameObject);
            Gamemanager.instance.GameOver();
        }
    
        else if(collision.gameObject.tag == "Ground")
        {   //adds to score
            Gamemanager.instance.IncrementScore();            
            gameObject.SetActive(false);
            //dust at position of spike collision
            GameObject dustEffect = Instantiate(dust,transform.position,Quaternion.identity);
            //destroys dust effect after short time
            
            Destroy(dustEffect, 2f);
            Destroy(gameObject, 3f);
        }
    
    }


}
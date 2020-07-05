using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float rotationSpeed;
    

    private void FixedUpdate()
    {
        transform.Rotate(0,0,rotationSpeed);
    }

    public void OnTriggerEnter2d(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
    
        else if(collision.gameObject.tag == "Ground")
        {
            Destroy(gameObject);
        }
    
    }


}

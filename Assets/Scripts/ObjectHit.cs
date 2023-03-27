using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    float red_val = 0.868f;
    float green_val = 0.413f;
    float blue_val = 0.756f;

    private void OnCollisionEnter(Collision other) 
    {
        // Debug.Log("Collided");
        
        if (other.gameObject.tag == "Player")
        {
            GetComponent<MeshRenderer>().material.color = new Color(red_val, green_val, blue_val);
            gameObject.tag = "Hit";
        }
        
    }
}

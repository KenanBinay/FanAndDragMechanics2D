using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fan : MonoBehaviour
{
    public GameObject fan;
    public Rigidbody2D addForce1,addForce2,addForce3,addForce4;
    
    [Range(0.0f, 10.0f)]
    public float fanForce;

    void Update()
    {      
           fan.transform.Rotate(0, 0, -2);
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        Debug.Log("TriggerStay!!");
        addForce1.AddForce(Vector2.right * fanForce);
        addForce2.AddForce(Vector2.right * fanForce);
        addForce3.AddForce(Vector2.right * fanForce);
        addForce4.AddForce(Vector2.right * fanForce);
    }

}

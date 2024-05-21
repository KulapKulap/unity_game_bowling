using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public float speed=5f, hspeed=10f, thrust=500f;
    private Rigidbody rb;
    private void Awake()
    {
        rb=GetComponent<Rigidbody>();
    }
    
    private void FixedUpdate()
    {
        float h=Input.GetAxis("Horizontal")*hspeed*Time.fixedDeltaTime;
        float v=Input.GetAxis("Vertical")*speed*Time.fixedDeltaTime;
        rb.velocity=transform.TransformDirection(new Vector3(v,rb.velocity.y,-h));
        
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name=="Block")
        {
            rb.AddForce(new Vector3(0,1,0)*thrust);
        }
    }
    
    void OnTriggerEnter(Collider other){
        if (other.gameObject.name=="Cube")
        
          Destroy(gameObject);  
        
        
    }
    void OnTriggerExit(Collider other){
        Debug.Log("OnTriggerExit");
    }
    void OnTriggerStay(Collider other){
        Debug.Log("OnTriggerStay");
    }
}

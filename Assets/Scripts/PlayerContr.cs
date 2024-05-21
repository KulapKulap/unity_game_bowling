using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class PlayerContr : MonoBehaviour
{
    public float speed=5f;
    public Rigidbody rb;
    private int score=0;
    public Text scoreText;

    private void Awake()
    {
        rb.GetComponent<Rigidbody>();
    }

    public void FixedUpdate()
    {
        float h=Input.GetAxis("Horizontal");
        float v=Input.GetAxis("Vertical");
        rb.AddForce(new Vector3(h,0,v)*speed*Time.fixedDeltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag=="CollectiveCube")
        {   
            score++;
            Destroy(other.gameObject);
            if (score!=5)
            scoreText.text="Score: "+score;
            else
            scoreText.text="u won!";
    }


    }


}

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

public class Basics : MonoBehaviour
{
    //[NonSerialized] public int nums=5;
    //[SerializeField] byte[] nums1=new byte[3];
    //[SerializeField] private int hi=10;
    //public List<string> words=new List<string>();
//    public GameObject obj;
//    public Transform target;
//    public BoxCollider box;
//    public Light light;
//    public GameObject[] objs=new GameObject[3];
      public Transform[] transform=new Transform[3];
      public float speed=5.0f, rotateSpeed=5.0f;


   public void Start(){
        //obj.SetActive(false);
        //obj.GetComponent<Transform>().position=new Vector3(10,0,0);
        //target.position=new Vector3(1,0,10);
        //light.intensity=0.5f;    
   }
   public void Update(){
     for (int i = 0; i < transform.Length; i++)
        {
                if (transform[i]==null)
                continue;
            transform[i].Translate(new Vector3(-1,0,0)*speed*Time.deltaTime);
            transform[i].Rotate(new Vector3(-1,0,0)*rotateSpeed*Time.deltaTime);
            float posX=transform[i].position.x;
            
            
            if (posX<-10f && transform[i].gameObject.name=="Cube")
            
                Destroy(transform[i].gameObject);
            
        }
   }
    
}
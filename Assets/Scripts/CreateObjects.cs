using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateObjects : MonoBehaviour
{
    public GameObject[] obj;

    void Update(){
        if (Input.GetKey(KeyCode.U))
        {
            StartCoroutine(Create3DObjects(3f));
        }
        
    }

    public void Create()
    {
        for (int i = 0; i < 5; i++)
        {
        //   GameObject newObject=Instantiate(obj, new Vector3(0,5,0), Quaternion.Euler(12f,-15f,-40f)) as GameObject;
        // newObject.GetComponent<Transform>().position=new Vector3(5,5,0);  
        Instantiate(obj[UnityEngine.Random.Range(0,obj.Length)],new Vector3(RandomNumber(),5,0),Quaternion.Euler(RandomNumber(),-15f,40f));
        }
        
    }
    public int RandomNumber(){
        return UnityEngine.Random.Range(0,10);
    }

    public IEnumerator Create3DObjects(float wait){
         while (true)
         {
            
            Instantiate(obj[UnityEngine.Random.Range(0,obj.Length)],new Vector3(RandomNumber(),5,0),Quaternion.Euler(RandomNumber(),-15f,40f));
            yield return new WaitForSeconds(wait);
         }
    }

    
}

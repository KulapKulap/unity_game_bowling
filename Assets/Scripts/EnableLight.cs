using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableLight : MonoBehaviour
{
    // Start is called before the first frame update
    public Light mainLight;
    public void Update(){
        if (Input.GetKeyUp(KeyCode.Space))
        {
            mainLight.enabled=!mainLight.enabled;
        }
    }
}

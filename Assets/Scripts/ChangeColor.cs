using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    private MeshRenderer _mesh;
    
    public void Awake(){
        _mesh=GetComponent<MeshRenderer>();

    }
    private void Update(){
        if (Input.GetKeyDown(KeyCode.A))
        
            _mesh.material.color=Color.yellow;
        
    }
}

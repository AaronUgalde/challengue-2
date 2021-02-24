using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControlelr : MonoBehaviour
{
    public float spaceInput;
    public GameObject dog;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetKeyDown(KeyCode.Space)){
           Instantiate(dog,transform.position,transform.rotation);
       }
    }
}

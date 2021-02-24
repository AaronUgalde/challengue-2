using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float xBound = -30;
    private float yBound = -1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x<xBound){
            Destroy(this.gameObject);
        }
        if(transform.position.y<yBound){
            Debug.Log("GAME OVER");
            Time.timeScale =0;
        }
    }
}

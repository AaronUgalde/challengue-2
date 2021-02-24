using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    
    public GameObject[] balls;
    public float spawnPositionY;
    public float spawnPositionZ;
    public float spawnRangeX=25;
    public int ballIndex;
    public int spawnDelay=1;
    public int spawnInterval=2;
    // Start is called before the first frame update
    void Start()
    {
        spawnPositionY=this.transform.position.y;
        spawnPositionZ=this.transform.position.z;
        InvokeRepeating("SpawnRandomBall",spawnDelay,spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    public void SpawnRandomBall (){
        float random = Random.Range(-spawnRangeX,spawnRangeX);
        Vector3 spawnPos = new Vector3(random,spawnPositionY,spawnPositionZ);
        ballIndex = Random.Range(0,balls.Length);
        Instantiate(balls[ballIndex],spawnPos,balls[ballIndex].transform.rotation);
    }
}

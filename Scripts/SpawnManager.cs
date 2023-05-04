using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] customerPrefabs; //reference to Prefabs array
    public Vector3 spawnPosition;
    public float spawnRangeX = 2.0f;
    public float spawnRangeZ = 50.0f;
    public float startDelay = 2.0f; //time in secs to start - *ADD RANDOM*
    public float repeatRate = 1.5f; //spawns at every x seconds *ADD RANDOM*
    private PlayerController playerContollerScript;

    // Start is called before the first frame update
    void Start()
    {
        playerContollerScript = GameObject.Find("Player").GetComponent<PlayerController>();
        InvokeRepeating("SpawnRandomCustomer", startDelay, repeatRate);
    }

    // Update is called once per frame
    void Update()
    {
       
    }
/*
    void SpawnRandomCustomer(){ //Spawns customers randomly
       if(playerContollerScript.gameOver == false){
        int customerIndex = Random.Range(0 , customerPrefabs.Length);
            if(customerIndex == 0 || customerIndex == 1){
                Vector3 spawnPosition = new Vector3( Random.Range(-spawnRangeX , spawnRangeX) , 0.5f , spawnRangeZ);
                Instantiate(customerPrefabs[customerIndex] , spawnPosition , customerPrefabs[customerIndex].transform.rotation);
            } else {
                Vector3 spawnPosition = new Vector3( Random.Range(-spawnRangeX , spawnRangeX) , 1.0f , spawnRangeZ);
                Instantiate(customerPrefabs[customerIndex] , spawnPosition , customerPrefabs[customerIndex].transform.rotation);
            }   
        }
    } */
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{

    public float speed = 10.0f;
    public float zBound = -5.0f;
    private PlayerController playerControllerScript;
    private GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
       if(gameManager.isGameActive == true){
            transform.Translate(Vector3.back * Time.deltaTime * speed);
       }
        if(transform.position.z < zBound && gameObject.CompareTag("Customer")){
            Destroy(gameObject);
            gameManager.UpdateScore(1);
        }
    }
}

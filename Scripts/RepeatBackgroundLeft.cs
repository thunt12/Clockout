using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackgroundLeft : MonoBehaviour
{

    public float speed = 10.0f;
    public Vector3 startPosition;
    public float repeatWidth;
    private PlayerController playerControllerScript;
    private GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;  //background begins at at 0 , 0 , 40
        repeatWidth = GetComponent<BoxCollider>().size.x/2;
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if(gameManager.isGameActive == true){
            transform.Translate(Vector3.right * Time.deltaTime * speed); // background continuously move backwards
        }

        if (transform.position.z < startPosition.z - repeatWidth){ // repeats background
            transform.position = startPosition;
        }
    }

}

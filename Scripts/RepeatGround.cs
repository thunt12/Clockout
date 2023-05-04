using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatGround : MonoBehaviour
{

    public float speed = 10.0f;
    public Vector3 startPosition;
    public float repeatWidth = 40.0f;
    private PlayerController playerControllerScript;
    private GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
      startPosition = transform.position;  //ground begins at at 0 , 0 , 40
      playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
      gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if(gameManager.isGameActive == true){
            transform.Translate(Vector3.back * Time.deltaTime * speed); // ground continuously move forwards
        }
        
        if (transform.position.z < startPosition.z - repeatWidth){//repeats
            transform.position = startPosition;
        
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

  public float horizontalInput;
  public float speed;
  public float xBounds = 2.0f;
  public bool isOnGround = true;
  private GameManager gameManager;
  

  // Start is called before the first frame update
  void Start()
  {
    gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
  }

  // Update is called once per frame
  void Update()
    { //Keeps players in bound
      horizontalInput = Input.GetAxis("Horizontal"); //Get's Unity's built-in player controls
      if(transform.position.x < -xBounds){
        transform.position = new Vector3(-xBounds , transform.position.y , transform.position.z);        
      }
      if(transform.position.x > xBounds){
        transform.position = new Vector3(xBounds , transform.position.y , transform.position.z);        
      }
      transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed); //Moves the Player left and right
    }

    //Custom Methods
    private void OnCollisionEnter(Collision collision){
        if(collision.gameObject.CompareTag("Ground")){
            isOnGround = true;
        } else if(collision.gameObject.CompareTag("Customer")){
            gameManager.GameOver();
        }
    }



}
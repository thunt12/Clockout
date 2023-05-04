using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI customersDodgedText;
    public TextMeshProUGUI gameOverText;
    public Button restartButton;
    public int score;
    public List<GameObject> customers;
    public bool isGameActive;
    public float spawnRate = 2.0f;
    public Vector3 spawnPosition;
    public float spawnRangeX = 2.0f;
    public float spawnRangeZ = 50.0f;
    public GameObject titleScreen;
    public GameObject playerUI;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Spawns random customers every x seconds
    IEnumerator SpawnCustomer(){
        while(isGameActive){
            yield return new WaitForSeconds(spawnRate);
            int index = Random.Range(0 , customers.Count);
            Vector3 spawnPosition = new Vector3( Random.Range(-spawnRangeX , spawnRangeX) , 1.0f , spawnRangeZ);
            Instantiate(customers[index] , spawnPosition , customers[index].transform.rotation);
        }
    }

    public void StartGame(int difficulty){
        isGameActive = true;
        StartCoroutine(SpawnCustomer());
        score = 0;
        spawnRate /= difficulty;
        customersDodgedText.text = "Customers Dodged: " + score;
        titleScreen.gameObject.SetActive(false);
        playerUI.SetActive(true);
    }

    // Will create an active Left Juke Button on game start
     public void PlayerUI(){
       
     }


    public void UpdateScore(int scoreToAdd){
        score += scoreToAdd;
        customersDodgedText.text = "Customers Dodged: " + score;
    }
    
    public void GameOver(){
        isGameActive = false;
        gameOverText.gameObject.SetActive(true);
        restartButton.gameObject.SetActive(true);
    }

    public void RestartGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
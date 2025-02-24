using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManagement : MonoBehaviour
{

    public GameObject player;
    public GameObject playerSpawnPoint;
    public Text scoreText;
    public GameObject gameOverText;    
    public GameObject lane1;
    public GameObject lane2;
    public GameObject lane3;

    private int currentScore;
    private float currentSpeed;
    private EnemySpawn lane1EnemyMovement;
    private EnemySpawn lane2EnemyMovement;
    private EnemySpawn lane3EnemyMovement;
    private bool gameOver;

    void Start()
    {
        gameOver = false;
        currentSpeed = 0.5f;
        currentScore = 0;
        scoreText.text = currentScore.ToString();        
        lane1EnemyMovement = lane1.GetComponent<EnemySpawn>();
        lane2EnemyMovement = lane2.GetComponent<EnemySpawn>();
        lane3EnemyMovement = lane3.GetComponent<EnemySpawn>();
        updateCarMovementSpeed(currentSpeed);        
    }

    void Update()
    {
        if(gameOver){
            if(Input.GetKeyDown(KeyCode.Space)){
                SceneManager.LoadScene("SampleScene");
            }
        }
    }

    public void createNewRun(){

        addPoint();
        player.transform.position = playerSpawnPoint.transform.position;
    }

    public void showGameOver(){
        gameOverText.SetActive(true);
        gameOver = true;
    }

    private void addPoint(){
        currentScore++;
        scoreText.text = currentScore.ToString();
        currentSpeed *= 1.5f;
        updateCarMovementSpeed(currentSpeed);
        updateCarSpawnCooldown();
    }

    private void updateCarMovementSpeed(float newSpeed){
        lane1EnemyMovement.carSpeed = newSpeed;
        lane2EnemyMovement.carSpeed = newSpeed;
        lane3EnemyMovement.carSpeed = newSpeed;
    }

    private void updateCarSpawnCooldown(){

        float newCoolDown = lane1EnemyMovement.cooldown - currentSpeed/2;

        if(newCoolDown < 0.5f){
            newCoolDown = 0.5f;
        }

        lane1EnemyMovement.cooldown = newCoolDown;
        lane2EnemyMovement.cooldown = newCoolDown;
        lane3EnemyMovement.cooldown = newCoolDown;
    }
}

using UnityEngine;
using UnityEngine.UI;

public class GameManagement : MonoBehaviour
{

    public GameObject player;
    public GameObject playerSpawnPoint;
    public Text scoreText;

    private int currentScore;

    void Start()
    {
        currentScore = 0;
        scoreText.text = currentScore.ToString();
    }

    public void createNewRun(){

        addPoint();
        player.transform.position = playerSpawnPoint.transform.position;
    }

    private void addPoint(){
        currentScore++;
        scoreText.text = currentScore.ToString();
    }
}

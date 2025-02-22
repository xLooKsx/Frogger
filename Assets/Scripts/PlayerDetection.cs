using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDetection : MonoBehaviour
{
    public bool enemy;
    public bool goalSpace;
    public GameManagement gameManagement;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player")){

            if(enemy){
                Destroy(collision.gameObject);
            } else if(goalSpace){
                Debug.Log("Parabéns!");
                gameManagement.createNewRun();
            }
        }
    }
}

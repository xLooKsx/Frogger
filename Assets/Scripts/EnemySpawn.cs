using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject carPrefab;
    public bool isRightDirection;

    public float cooldown;
    public float currentCooldownTime;
    public bool isTimeToGenerateNewCar;
    void Start()
    {
        isTimeToGenerateNewCar = true;
        currentCooldownTime = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        InstatiateCars();
        CalculateCoolDown();
    }

    private void CalculateCoolDown()
    {
        if(!isTimeToGenerateNewCar && currentCooldownTime >= cooldown){
            isTimeToGenerateNewCar = true;
        }else{
            currentCooldownTime += Time.deltaTime;
        }
    }

    private void InstatiateCars(){

        if(isTimeToGenerateNewCar){

            GameObject instantiatedObject = GameObject.Instantiate(carPrefab, this.transform.position, Quaternion.identity);
            instantiatedObject.GetComponent<EnemyMovement>().isRightDirection = this.isRightDirection;
            instantiatedObject.tag = isRightDirection ? "RightCar" : "LeftCar";

            isTimeToGenerateNewCar = false;
            currentCooldownTime = 0;
        }

    }
}

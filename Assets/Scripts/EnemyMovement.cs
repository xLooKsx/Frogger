using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public bool isRightDirection;

    private float speed;
    private Vector3 direction;
    void Start()
    {
        speed = 0.5f;
        DefineWalkDirection();        
    }

    private void DefineWalkDirection()
    {
        if(isRightDirection){
            direction = Vector3.right;
        }else{
            direction = Vector3.left;
        }
    }

    // Update is called once per frame
    void Update()
    {
        HorizontalMovement();
    }

    private void HorizontalMovement(){

        this.gameObject.transform.position += this.speed * Time.deltaTime * direction; 
    }
}

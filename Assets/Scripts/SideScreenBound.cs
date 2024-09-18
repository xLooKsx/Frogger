using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideScreenBound : MonoBehaviour
{

    public bool isRightBound;

   private void OnTriggerExit2D(Collider2D other) {

    if(other.gameObject.CompareTag("RightCar") && this.isRightBound){
        Destroy(other.gameObject, 3);
    }else if(other.gameObject.CompareTag("LeftCar") && !this.isRightBound){
        Destroy(other.gameObject, 3);
    }
   }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.CompareTag("Player")){
        Destroy(other.gameObject);
    }
    }
}

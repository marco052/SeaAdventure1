using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    // Update is called once per frame
    void Update(){
        
    }

    /*private void OnTriggerEnter2D(Collider2D collision) {
        if(collision.CompareTag("Bullet")){
            Debug.Log("aaaaa");


        }
    }*/

    private void OnTriggerEnter2D(Collider2D collision){
        if(collision.tag == "Bullet"){
            GameController.Points++;
            Debug.Log(GameController.Points);
            Destroy(gameObject, 0.1f);
        }


    }
}

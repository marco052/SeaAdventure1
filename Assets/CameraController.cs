using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Time.timeScale == 1){
            transform.position = new Vector3(transform.position.x, transform.position.y+0.00051f, transform.position.z);
        }
       
    }
}

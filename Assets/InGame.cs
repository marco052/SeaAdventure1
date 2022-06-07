using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InGame : MonoBehaviour
{
    public Text textPoints;

    // Update is called once per frame
    void Update()
    {
        this.textPoints.text = GameController.Points.ToString();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ChangeScene : MonoBehaviour
{
    // Start is called before the first frame update
    public string nomeDaCena;

    public void ChangeFunction(){
        SceneManager.LoadScene(nomeDaCena);
        if(nomeDaCena == "Game"){
            GameController.Points = (0);
        }
    }

    public void Quit(){
        Application.Quit();
    }
}

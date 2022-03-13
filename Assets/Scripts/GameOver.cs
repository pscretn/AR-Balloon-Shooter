using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public float balloonpos;
    void Update()
    {
        //get position of game object in z-axis
     balloonpos = transform.position.y;

     if(balloonpos >=1.5f){
          SceneManager.LoadScene("GameOver");
     }
    }
}

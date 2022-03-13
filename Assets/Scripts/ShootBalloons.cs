using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootBalloons : MonoBehaviour
{
    public GameObject arCamera;
    public GameObject Smoke;
    public int point=0;
      void Start()
    {
        ScoreCounter.score = 0;
    }
    public void Shoot(){

        RaycastHit hit;
        if(Physics.Raycast(arCamera.transform.position,arCamera.transform.forward,out hit)){
            if(hit.collider.gameObject.tag == "Balloon"){
                Destroy(hit.transform.gameObject);
                Instantiate(Smoke,hit.point,Quaternion.LookRotation(hit.normal));
                point++;
                ScoreCounter.score = point;
            }
        }
    }
}

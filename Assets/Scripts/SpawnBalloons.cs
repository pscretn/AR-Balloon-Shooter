using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBalloons : MonoBehaviour
{
    public Transform[] SpawnPositions;
    public GameObject[] Balloons;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(StartSpawning());
    }

    IEnumerator StartSpawning(){
        yield return new WaitForSeconds(3);
        
        for(int i=0;i<3;i++){
            int random; 
            if(i==0){
                random = Random.Range(0,4);
            }
            else if(i==1){
                random = Random.Range(4,7);
            }
            else{
                random = Random.Range(7,10);
            }
        
            Instantiate(Balloons[random],SpawnPositions[i].position,Quaternion.identity);
        }

        StartCoroutine(StartSpawning());
    }
}

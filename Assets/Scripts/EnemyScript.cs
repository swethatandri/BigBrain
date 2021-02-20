using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EnemyScript : MonoBehaviour
{
    // Start is called before the first frame update

    private GameObject brain;
    public float speed = 3f;
    private float enemyBound = -5;
    public GameObject player;
    public PlayerController pc;
    

  



    public int referenceNumber;


    void Start()
    {
        
        player = GameObject.Find("Player");
        pc = player.GetComponent<PlayerController>();

        referenceNumber = 10;
        
    }

    // Update is called once per frame
    void Update()
    {
       
        transform.Translate(Vector3.back * speed * Time.deltaTime); 
        destoyEnemy();

        UpdateSpeed();

        if(pc.gameOver == true){
            speed = 0;
        } 

        
    }


    void destoyEnemy(){

        if(transform.position.z < enemyBound){

            Destroy(gameObject);
        }

    }

   

    void UpdateSpeed(){


        int score = GameObject.Find("Player").GetComponent<PlayerController>().score;

        if(score >= referenceNumber){

            speed *= 1.2f;

            referenceNumber += 10;
            


        }

    }

   
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PillMovement : MonoBehaviour
{

    // Start is called before the first frame update

    public float pillspeed = 5f;

    public PlayerController pc; 
    

    void Start()
    {

        pc = GameObject.Find("Player").GetComponent<PlayerController>();
        StartCoroutine(pillTime());
        
    }

    // Update is called once per frame
    void Update()
    {

        destroyPill();

        transform.Translate(Vector3.back * pillspeed *Time.deltaTime);

        if(pc.gameOver == true){
            pillspeed = 0;
        }


        
    }

    void destroyPill(){

        if(transform.position.z < -5){

            Destroy(gameObject);
        }


    }

    IEnumerator pillTime(int seconds = 4){

        if(pc.timedGameOver == false){


        while(seconds > 0){

            yield return new WaitForSeconds(1);
            seconds--;

            
        }

        Destroy(gameObject);
        }


    }
}

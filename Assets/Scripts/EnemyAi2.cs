using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAi2 : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform tr_Player;
    float f_RotSpeed = 3.0f, f_MoveSpeed = 3.0f;



    private void Start()
    {

         tr_Player = GameObject.FindGameObjectWithTag("player").transform;
       
      
    }
    

   void Update()
    {
       
        // Look at Player
       transform.rotation = Quaternion.Slerp(transform.rotation
                                              , Quaternion.LookRotation(tr_Player.position - transform.position)
                                              , f_RotSpeed * Time.deltaTime);

        // Move at Player
        // transform.LookAt(tr_Player);
        transform.position += transform.forward * f_MoveSpeed * Time.deltaTime;
       
        
    }
    
}

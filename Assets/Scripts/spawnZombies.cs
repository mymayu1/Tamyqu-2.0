using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnZombies : MonoBehaviour
{  //https://answers.unity.com/questions/714835/best-way-to-spawn-prefabs-in-a-circle.html
    // Start is called before the first frame update
     public int numZombies = 60;
     public GameObject prefab;
     Vector3 center;
     void Start() {
         center = new Vector3(0.0f, 0.0f, 0.0f); // center of
         for (int i = 0; i < numZombies; i++){
             Vector3 pos = new Vector3(3.28f,28.64f,-2.11f);
             Quaternion rot = new Quaternion(0.0f,0.0f,0.0f,1f);
             Instantiate(prefab, pos, rot);
         }
     }
 

}

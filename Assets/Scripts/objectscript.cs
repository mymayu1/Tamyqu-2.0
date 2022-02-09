using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectscript : MonoBehaviour
{    public int score;
    PlayfabManager playfabManager;
    // Start is called before the first frame update
    void Start()
    {  playfabManager= FindObjectOfType<PlayfabManager>();
        score=0;
    }

    // Update is called once per frame
    void Update()
    {  // Debug.Log("Score= "+ score);
         if(Input.GetKeyDown(KeyCode.Space)) //if player gets hit
        {
            score+=1;
        }
         if(Input.GetKeyDown(KeyCode.A)) //if player gets points
        {
            gameover(score);
        }
    }
    public void gameover(int score){
        playfabManager.SendLeaderboard(score);
       Debug.Log((score));
    }
}

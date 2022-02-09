using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CountZombie : MonoBehaviour
{
    public static int scoreValue = 0;
    TextMeshProUGUI score;
    // Start is called before the first frame update
    void Start()
    {
        score = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        score.text = scoreValue + " / 20";
    }
     void Awake ()
 {
     score = GetComponent <TextMeshProUGUI> ();
     scoreValue = 0;
 }
}

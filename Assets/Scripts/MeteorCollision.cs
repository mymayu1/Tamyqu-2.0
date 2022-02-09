using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorCollision : MonoBehaviour
{
    public playerhealth playerhealth;

    // Start is called before the first frame update
    void Start()
    {
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "player")
        {     soundmanager.PlaySound("fire");

            playerhealth.TakeDamage(1);
            ScoreManager.instance.MinusPoint();
        }
        //if (collision.gameObject.tag == "Planet")
        //{
        //    particle.Play();
        //    Destroy(collision.gameObject);
        //}
    }
}

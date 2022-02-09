using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerhealth : MonoBehaviour
{   
    public int MaxHealth= 10;
    public int currentHealth;
    public healthbar healthbar;
    public timer timer;
    public GameObject GameOverScreen;
    private Animator animator;

    // TODO= if in collision with enemy //if u get token
    void Start()
    {
        currentHealth=MaxHealth;
        healthbar.setMaxHealth(currentHealth);
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void TakeDamage(int damage)
    {  
        currentHealth-= damage;
        healthbar.setHealth(currentHealth);
        if(currentHealth<=0){
             GameOverScreen.SetActive(true);
             soundmanager.PlaySound("pain");
             soundmanager.PlaySound("gameover");
             timer.Timeout();
             Debug.Log(" you died");
            Time.timeScale = 0f;
        }
    }
      public void AddHealth(int addedhealth)
    {   soundmanager.PlaySound("potion");
        currentHealth += addedhealth;
        healthbar.setHealth(currentHealth);

        if(currentHealth==10){
            currentHealth=MaxHealth;
            healthbar.setHealth(MaxHealth);

        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "fire")
        {
            TakeDamage(1);
            soundmanager.PlaySound("fire");
        }

        if (collision.gameObject.tag == "enemy")
        {
            TakeDamage(1);
            //soundmanager.PlaySound("zombie");
            //animator.Play("ZombieAttack", 0, 0);

        }
        if (collision.gameObject.tag == "potion")
        {
            AddHealth(2);
            soundmanager.PlaySound("potion");
            Destroy(collision.gameObject);
        }
        // if (collision.gameObject.tag == "meteor")
        //{   soundmanager.PlaySound("fire");

          //  TakeDamage(2);
       // }
    }
}

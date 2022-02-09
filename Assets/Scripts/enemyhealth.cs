
using UnityEngine;

public class enemyhealth : MonoBehaviour
{
    
    public int MaxHealth = 30;
    public float currentHealth;
    private Animator animator;
    public playerhealth playerhealth;

    // TODO= if in collision with enemy //if u get token
    void Awake()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void TakeDamage(float amount)
    {
        currentHealth -= amount;
        ScoreManager.instance.AddPoint();
        animator.Play("ReactionHit-3", 0, 0);

        if (currentHealth <= 0)
        {
            ScoreManager.instance.AddDeadPoint();
            Debug.Log("enemy died");
            Die();
        }
    }

    void Die()
    {
        CountZombie.scoreValue += 1;
        Destroy(gameObject);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "player")
        {
            playerhealth.TakeDamage(1);
            ScoreManager.instance.MinusPoint();
            soundmanager.PlaySound("zombie");
            animator.Play("ZombieAttack", 0, 0);

        }
    }
}

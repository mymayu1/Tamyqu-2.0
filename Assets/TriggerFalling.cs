using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerFalling : MonoBehaviour
{
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "player")
        {
            animator.Play("Falling");
            Destroy(this.gameObject);
        }
    }
}

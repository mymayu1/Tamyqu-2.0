using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float playerSpeed = 10f;
    public float playerRotationSpeed = 100f;
    public float jumpForce = 220;
    public Rigidbody rb;
    public bool playerOnGlobe;
    public LayerMask groundedMask;
    

    private Animator animator;


    private void Start()
    {
        animator = GetComponent<Animator>();
       
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "TriggerZone")
        {
            animator.Play("Falling", 0, 0);
            Destroy(other.gameObject);
        }
        if (other.gameObject.tag == "TriggerZone2")
        {
            animator.Play("Landing", 0, 0);
            Destroy(other.gameObject);
        }
    }



    // Update is called once per frame
    void FixedUpdate()
    {
        float translation = Input.GetAxis("Vertical") * playerSpeed * Time.deltaTime;
        float rotation = Input.GetAxis("Horizontal") * playerRotationSpeed * Time.deltaTime;

        transform.Translate(0, 0, translation);

        transform.Rotate(0, rotation, 0);

        if (Input.GetAxis("Vertical") != 0 ) 
        {
            animator.SetBool("isRunning", true);
            
            // soundmanager.PlaySound("run");
        }

        if (Input.GetAxis("Vertical") == 0)
        {
            animator.SetBool("isRunning", false);
            
        }

        if(Input.GetButtonDown("Fire1"))
        {
            animator.SetBool("hasPistol", true);

        }
        if(!Input.GetButtonDown("Fire1"))
        {
            animator.SetBool("hasPistol", false);

        }
        
        if (Input.GetButtonDown("Jump"))
        {  soundmanager.PlaySound("jump");
            animator.Play("Jump", 0, 0);
            if (playerOnGlobe)
            {
                rb.AddForce(transform.up * jumpForce);
                animator.SetBool("isJumping", true);
            }
            //Debug.Log("jumping");
        }

       
         

        playerOnGlobe = false;
        Ray ray = new Ray(transform.position, -transform.up);

        RaycastHit hit;
        if(playerOnGlobe)
        {    
            animator.SetBool("isJumping", false);  
        }

        if(Physics.Raycast(ray, out hit, 1 + 0.1f, groundedMask))
        {
           
            playerOnGlobe = true;
            //Debug.Log("not jumping");

        }

        /*if ()
        {
            animator.Play("Falling", 0, 0);
        }*/
        
        
      
    }
    
    
    
}

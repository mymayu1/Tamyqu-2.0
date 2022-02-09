
using UnityEngine;

public class gun : MonoBehaviour
{
    public float damage = 10f;
    public float range = 150f ;
    public Camera fpsCam;
    public ParticleSystem particle;
    public GameObject impactEffect;
    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();

    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }
    
    void Shoot()
    {
        particle.Play();
        RaycastHit hit;
        if(Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);
            enemyhealth target = hit.transform.GetComponent<enemyhealth>();
            if(target !=null )
            {
                target.TakeDamage(damage);
            }
            soundmanager.PlaySound("laser");
            GameObject destroyImpact = Instantiate(impactEffect, hit.point, Quaternion.LookRotation(hit.normal));
            //animator.SetBool("Dead", true);
            Destroy(destroyImpact, .5f);

        }
    }
}

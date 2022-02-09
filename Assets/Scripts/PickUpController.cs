using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpController : MonoBehaviour
{
    public gun gunscript;
    public Rigidbody rb;
    public BoxCollider col;
    public Transform player, gunContainer, fpsCam;
    public float pickUpRange;
    
    private void Start()
    {
        gunscript.enabled = true;
        rb.isKinematic = true;
        col.isTrigger = true;

    }
    private void Update(){
        Vector3 distancetoPlayer = player.position - transform.position;
        if(distancetoPlayer.magnitude <= pickUpRange) PickUp();
    }
    private void PickUp()
    {
        rb.isKinematic = true;
        col.isTrigger = true;

        //Make weapon move to its default position
        transform.SetParent(gunContainer);
        transform.localPosition = Vector3.zero;
        transform.localRotation = Quaternion.Euler(Vector3.zero);


        gunscript.enabled = true;
       
    }
}

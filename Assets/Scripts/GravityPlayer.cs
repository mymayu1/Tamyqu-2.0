using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[RequireComponent (typeof (Rigidbody))]
public class GravityPlayer : MonoBehaviour
{
    public GravityGlobe attractor;
    private Transform myTransform;

    void Start()
    {
        GetComponent<Rigidbody> ().constraints = RigidbodyConstraints.FreezeRotation;
        GetComponent<Rigidbody> ().useGravity = false;
        myTransform = transform;

    }
   /* void Awake()
    {
        attractor = GameObject.FindGameObjectWithTag("Planet").GetComponent<GravityGlobe>();
		rigidbody = GetComponent<Rigidbody> ();

		// Disable rigidbody gravity and rotation as this is simulated in GravityAttractor script
		rigidbody.useGravity = false;
		rigidbody.constraints = RigidbodyConstraints.FreezeRotation;
    }
    */
    // Update is called once per frame
    void Update()
    {
        attractor.Attract(myTransform);
    }
}

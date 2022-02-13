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

    // Update is called once per frame
    void Update()
    {
        attractor.Attract(myTransform);
    }
}

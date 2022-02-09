using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityGlobe : MonoBehaviour
{
    public float gravity= -10;	

    public void Attract(Transform body){
        Vector3 gravityUp = (body.position - transform.position).normalized;
		Vector3 bodyUp = body.up;
		
		body.GetComponent<Rigidbody>().AddForce(gravityUp * gravity);
		// Apply downwards gravity to body
		//body.AddForce(gravityUp * gravity);

		Quaternion targetRotation = Quaternion.FromToRotation(bodyUp,gravityUp) * body.rotation;
		body.rotation = Quaternion.Slerp(body.rotation,targetRotation, 50 * Time.deltaTime);
		// Allign bodies up axis with the centre of planet
		//body.rotation = Quaternion.FromToRotation(localUp,gravityUp) * body.rotation;
}
}
  
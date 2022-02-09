using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
     public float moveSpeed = 15f;
    public float rotationSpeed = 100f;
    private bool isWandering = false;
    private bool isRotatingLeft = false;
    private bool isRotatingRight = false;
    private bool isWalking = false;
    Rigidbody rb;
    private Vector3 startingPoint;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame

    private Vector3 GetRoamingPosition()
    {
        Vector3 randomVector = new Vector3(UnityEngine.Random.Range(-1f,1f), UnityEngine.Random.Range(-1f,1f)).normalized;    
        return startingPoint + randomVector * Random.Range(50f, 50f);

    }
    void Update()
    {
         if(isWandering ==false)
        {
            StartCoroutine(Wander());

        }

        if(isRotatingRight == true)
        {
            transform.Rotate(transform.up * Time.deltaTime * rotationSpeed);

        }
        if(isRotatingLeft == true)
        {
            transform.Rotate(transform.up * Time.deltaTime * -rotationSpeed);

        }
        if(isWalking == true)
        {
            rb.AddForce(transform.forward * moveSpeed);
        }
    }

     IEnumerator Wander()
    {
        int rotationTime = Random.Range(1,3);
        int rotationWait = Random.Range(1,3);
        int rotationDirection = Random.Range(1,2);
        int walkWait = Random.Range(1,2);
        int walkTime = Random.Range(3,3);

        isWandering = true;

        yield return new WaitForSeconds(walkWait);

        isWalking = true;

        yield return new WaitForSeconds(walkWait);

        isWalking = false;

        yield return new WaitForSeconds(rotationWait);
        
        if(rotationDirection == 1)
        {
            isRotatingLeft = true;
            yield return new WaitForSeconds(rotationTime);
            isRotatingLeft = false;

        }

        if (rotationDirection == 2)
        {
            isRotatingRight = true;
            yield return new WaitForSeconds(rotationTime);
            isRotatingRight = false;
        }

        isWandering = false;
    }
}

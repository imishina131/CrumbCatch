using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingObjectsScript : MonoBehaviour
{
    private int targetY = -20;
    Vector3 target;
    // Start is called before the first frame update
    void Awake()
    {
        Reset();
    }

    void Reset()
    {
        target = transform.position;
        target.y = targetY;
    }

    // Update is called once per frame
    void Update()
    {
        FallDown();
    }

    void FallDown()
    {
        float step = 3f*Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, target, step);
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Basket")
        {

        }
        else if(other.gameObject.tag == "DeadZone")
        {
            Destroy(gameObject);
            Debug.Log("Missed");
        }
    }
}

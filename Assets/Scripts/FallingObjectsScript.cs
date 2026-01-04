using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FallingObjectsScript : MonoBehaviour
{
    private int targetY = -20;
    Vector3 target;
    bool moving = true;
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

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        FallDown();
    }

    void FallDown()
    {
        if(moving)
        {
            float step = 3f*Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, target, step);
        }
    }

    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "DeadZone")
        {
            Debug.Log("Missed");
            moving = false;
            Destroy(gameObject);
            Debug.Log("Missed");
        }
        if(other.gameObject.tag == "Basket")
        {
            Destroy(gameObject);
        }
    }
}

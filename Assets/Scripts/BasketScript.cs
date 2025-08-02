using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move()
    {
        if(Input.GetKey(KeyCode.A))
        {
            this.transform.Translate(Vector3.left * 4.0f * Time.deltaTime);
        }

        if(Input.GetKey(KeyCode.D))
        {
            this.transform.Translate(Vector3.right * 4.0f *Time.deltaTime);
        }
    }
}

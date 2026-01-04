using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BasketScript : MonoBehaviour
{

    public Slider slider;
    public int crumbsCount = 0;


    // Start is called before the first frame update
    void Start()
    {
        slider.maxValue = 20;
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
            this.transform.Translate(Vector3.left * 6.0f * Time.deltaTime);
        }

        if(Input.GetKey(KeyCode.D))
        {
            this.transform.Translate(Vector3.right * 6.0f *Time.deltaTime);
        }
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "GoodFood")
        {
            crumbsCount++;
        }
        else if (other.gameObject.tag == "BadFood")
        {
            crumbsCount--;
        }
        Debug.Log("Crumbs: " + crumbsCount);
        slider.value = crumbsCount;
    }
}

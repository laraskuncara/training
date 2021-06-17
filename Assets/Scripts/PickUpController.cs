using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpController : MonoBehaviour
{
    public float index;
    void Start()
    {
        index = index * 0.57f;
        transform.position = new Vector3(2*Mathf.Sin(index)*Mathf.PI, transform.position.y, 2*Mathf.Cos(index)*Mathf.PI);;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate (new Vector3 (15, 30, 45) * Time.deltaTime);
        transform.position = new Vector3(2*Mathf.Sin(index)*Mathf.PI, transform.position.y, 2*Mathf.Cos(index)*Mathf.PI);
        index = index + Time.deltaTime/5;
    }
}

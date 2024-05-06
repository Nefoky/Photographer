using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int speed = 30;
    private float horizontal;
    private float vertical;
    public int speedRotation = 50;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        transform.Translate(new Vector3(0,0,1) * Time.deltaTime * speed * vertical);
        transform.Rotate(Vector3.up * Time.deltaTime *speedRotation * horizontal);
    }
}

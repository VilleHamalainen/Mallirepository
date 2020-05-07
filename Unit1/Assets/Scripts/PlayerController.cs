using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    private float horizontalInput;
    private float forwardInput;
    private float speed = 20f;
    private float turnSpeed = 45f;
    void Start()
    {
//        Debug.Log("login testaaminen");
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        //moves car "forward" on Z-axis
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        //turns cas in X-asix
        transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);
        //this.transform.Rotate()
        
        MoveCar();
    }

    private static void MoveCar()
    {
      // move the vehicle
    }
}

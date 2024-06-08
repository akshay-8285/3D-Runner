//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;


//public class PlayerController : MonoBehaviour
//{
//    public float speed = 5;
//    public float rotationSpeed;
//    private Rigidbody rb;



//    void Start()
//    {

//        rb = GetComponent<Rigidbody>();
//    }

//    // Update is called once per frame
//    void Update()
//    {
//       float verticalMovement = speed * Time.deltaTime;
//        transform.Translate(Vector3.forward * verticalMovement);

//        float Rotaion = Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime;
//        transform.Rotate(Vector3.up * Rotaion);


//    }
//}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float walkSpeed = 2f;
    public float runSpeed = 5f;
    public float rotationSpeed = 100f;
    private Rigidbody rb;
    private Animator animator;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        HandleMovement();
    }

    private void HandleMovement()
    {
        float speed = 0f;

        bool isWalking = animator.GetBool("walking");
        bool isRunning = animator.GetBool("running");

        if (isRunning)
        {
            speed = runSpeed;
        }
        else if (isWalking)
        {
            speed = walkSpeed;
        }

        float verticalMovement = speed * Time.deltaTime;
        transform.Translate(Vector3.forward * verticalMovement);

        float rotation = Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime;
        transform.Rotate(Vector3.up * rotation);
    }
}

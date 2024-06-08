//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class AnimationController : MonoBehaviour
//{

//    Animator animator;
//    int walkingHash;
//    int runningHash;
//    void Start()
//    {
//        animator = GetComponent<Animator>();
//        walkingHash = Animator.StringToHash("walking");
//        runningHash = Animator.StringToHash("running");

//    }

//    // Update is called once per frame
//    void Update()
//    {
//        bool running = animator.GetBool(runningHash);
//        bool walking = animator.GetBool(walkingHash);
//        bool forwardpress = Input.GetKey("w");
//        bool runningPress = Input.GetKey("r");

//        if (!walking && forwardpress)
//        {
//            animator.SetBool(walkingHash, true);
//        }
//        if(walking && ! forwardpress)
//        {
//            animator.SetBool(walkingHash, false);
//        }
//        if(!running &&(walking && forwardpress))
//        {
//            animator.SetBool(runningHash, true);
//        }
//        if(running && (!walking || !forwardpress))
//        {
//            animator.SetBool(runningHash, false);
//        }
//    }
//}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    Animator animator;
    int walkingHash;
    int runningHash;
    PlayerController playerController;

    void Start()
    {
        animator = GetComponent<Animator>();
        playerController = GetComponent<PlayerController>();

        walkingHash = Animator.StringToHash("walking");
        runningHash = Animator.StringToHash("running");
    }

    void Update()
    {
        HandleAnimation();
    }

    private void HandleAnimation()
    {
        bool isWalking = animator.GetBool(walkingHash);
        bool isRunning = animator.GetBool(runningHash);
        bool forwardPress = Input.GetKey("w");
        bool runningPress = Input.GetKey("r");

        if (!isWalking && forwardPress)
        {
            animator.SetBool(walkingHash, true);
        }
        if (isWalking && !forwardPress)
        {
            animator.SetBool(walkingHash, false);
        }
        if (!isRunning && (forwardPress && runningPress))
        {
            animator.SetBool(runningHash, true);
        }
        if (isRunning && (!forwardPress || !runningPress))
        {
            animator.SetBool(runningHash, false);
        }
    }
}


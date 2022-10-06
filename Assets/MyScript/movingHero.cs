using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingHero : MonoBehaviour
{
    [SerializeField] private float movementSpeed = 5f;
    [SerializeField] private Animator _animator;

    private bool runForward = false;
    private bool runBackward = false;
    private bool runRight = false;
    private bool runLeft = false;

    private Vector2 velocity;

    private void Update()
    {
        velocity.x = Input.GetAxis("Horizontal") * movementSpeed * Time.deltaTime;
        velocity.y = Input.GetAxis("Vertical") * movementSpeed * Time.deltaTime;

        transform.Translate(velocity.x, 0f, velocity.y);

        // if (Input.GetKey(KeyCode.W))
        // {
        //     runForward = true;
        //     _animator.SetBool("Run", runForward);
        // }
        // else
        // {
        //     runForward = false;
        //     _animator.SetBool("Run", runForward);
        // }
        AnimationForward();
        AnimationBackward();
        AnimationRight();
        AnimationLeft();


    }

    private void AnimationForward()
    {
        if (Input.GetKey(KeyCode.W))
        {
            runForward = true;
            _animator.SetBool("Run", runForward);
        }
        else
        {
            runForward = false;
            _animator.SetBool("Run", runForward);
        }
    }
    private void AnimationBackward()
    {
        if (Input.GetKey(KeyCode.S))
        {
            runBackward = true;
            _animator.SetBool("BackwardRun", runBackward);
        }
        else
        {
            runBackward = false;
            _animator.SetBool("BackwardRun", runBackward);
        }
    }
    private void AnimationRight()
    {
        if (Input.GetKey(KeyCode.D))
        {
            runRight = true;
            _animator.SetBool("RightRun", runRight);
        }
        else
        {
            runRight = false;
            _animator.SetBool("RightRun", runRight);
        }
    }
    private void AnimationLeft()
    {
        if (Input.GetKey(KeyCode.A))
        {
            runLeft = true;
            _animator.SetBool("LeftRun", runLeft);
        }
        else
        {
            runLeft = false;
            _animator.SetBool("LeftRun", runLeft);
        }
    }

}

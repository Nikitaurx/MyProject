using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingHero : MonoBehaviour
{
    [SerializeField] private float movementSpeed = 5f;
    [SerializeField] private Animator _animator;

    private bool runForward = false;
    private bool runBackward = false;

    private Vector2 velocity;

    private void Update()
    {
        velocity.x = Input.GetAxis("Horizontal") * movementSpeed * Time.deltaTime;
        velocity.y = Input.GetAxis("Vertical") * movementSpeed * Time.deltaTime;

        transform.Translate(velocity.x, 0f, velocity.y);

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

}

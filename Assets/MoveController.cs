using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveController : MonoBehaviour
{
    [SerializeField] private float movementSpeed = 5f;

    private Vector2 velocity;

    private void Update1()
    {
        velocity.x = Input.GetAxis("Horizontal") * movementSpeed * Time.deltaTime;
        velocity.y = Input.GetAxis("Vertical") * movementSpeed * Time.deltaTime;

        transform.Translate(velocity.x, 0f, velocity.y);
    }

}
 
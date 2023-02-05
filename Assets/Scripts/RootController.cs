using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickController : MonoBehaviour
{
    public Rigidbody2D rigidbody2d;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 moveDirection = new Vector2(Input.GetAxisRaw("Horizontal"), 0);

        if(rigidbody2d.bodyType == RigidbodyType2D.Kinematic)
        {
           // rigidbody2d.MovePosition(rigidbody2d.position + moveDirection * kVelocity * Time.deltaTime);
        }
    }
}

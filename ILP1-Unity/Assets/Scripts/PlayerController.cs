using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    Rigidbody2D rBody;

    [SerializeField]
    float moveSpeed = 1;

    [SerializeField]
    float jumpForce = 1;

    Vector3 moveVec = Vector3.zero;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //move player left and right
        moveVec.x = Input.GetAxis("Horizontal");
        transform.Translate(moveVec * moveSpeed);
        moveVec.Set(0, 0, 0);

        //jump
        if (canJump == true && Input.GetAxis("Jump") == 1)
        {
            rBody.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            canJump = false;
        }
    }


    public bool canJump = true;
}

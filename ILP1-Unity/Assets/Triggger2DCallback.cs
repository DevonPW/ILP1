using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triggger2DCallback : MonoBehaviour
{
    [SerializeField]
    public PlayerController playerController;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        playerController.canJump = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        playerController.canJump = false;
    }
}

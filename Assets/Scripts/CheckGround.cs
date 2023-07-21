using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckGround : MonoBehaviour
{
   
    public static bool isGroundedTwo;

    private void OnTriggerEnter2D(Collider2D other)
    {
        isGroundedTwo = true;
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        isGroundedTwo = false;
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemonEnemie : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D other)
    {

        if (other.transform.CompareTag("Player"))
        {
            Debug.Log("Player Damaged");
            Destroy(other.gameObject);
        }


    }

}

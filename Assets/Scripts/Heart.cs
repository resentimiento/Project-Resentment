using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Audio;

public class Heart : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("Player"))
        {
            //DESTRUIR EL OBJETO
            Destroy(gameObject);

            //APAGAR EL OBJETO
            //gameObject.SetActive(false);
        }

    }

}

using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Audio;

public class Heart : MonoBehaviour
{

	public GameObject brainItem;

	void Start()
	{
		brainItem.SetActive(false);
	}
	
	void Update()
	{
		brainItem.SetActive(false);
	}

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("Player"))
        {
            //DESTRUIR EL OBJETO
            Destroy(gameObject);

	brainItem.SetActive(true);
        }
	

    }

}

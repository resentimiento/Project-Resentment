using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemonEnemie : MonoBehaviour
{

	[SerializeField] private GameObject youLosePanel;
	
	public AudioSource playerKilled;
		
    private void OnCollisionEnter2D(Collision2D other)
    {

        if (other.transform.CompareTag("Player"))
        {
	playerKilled.Play();
            	Destroy(other.gameObject);
	Time.timeScale = 0f;
	youLosePanel.SetActive(true);
        }


    }

}

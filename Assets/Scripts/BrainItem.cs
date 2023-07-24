using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrainItem : MonoBehaviour
{

    //Declaramos una variable para el Panel de Nivel Completado
    public GameObject levelCompletePanel;

     //Declaramos un AudioSource para un sonido cuando recoja el item
	public AudioSource itemPicked;

    //Declaramos una funcion privada que tomara el Trigger de Entrada de otro Collider
    private void OnTriggerEnter2D(Collider2D other)
    {

	//Si el objeto con TAG Player toca el objeto con Script entonces
    	if(other.CompareTag("Player"))
	{
		Destroy(gameObject);
		itemPicked.Play();
		Time.timeScale = 0f;
		Debug.Log("Nivel Completado");
		levelCompletePanel.SetActive(true);	
	}
    }

}

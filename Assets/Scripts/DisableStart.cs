using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableStart : MonoBehaviour
{

    public GameObject startMenu; //Declaramos un objeto de la clase GameObject para START MENU
    public GameObject tittlesMenu; //Declaramos un objeto de la clase GameObject para TITTLES MENU

    public AudioSource startGameSound;	


    // Start is called before the first frame update
    void Start()
    {
        startMenu.SetActive(true);
        tittlesMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Return))
        {
            startMenu.SetActive(false);
            startGameSound.Play();
            tittlesMenu.SetActive(true);
            gameObject.SetActive(false);
        }

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteract : MonoBehaviour {

    private GameObject currentInterObj = null;
	
	void Update () {
        //Envio da Interação com o objeto
	if (Input.GetButtonDown("Interact") && currentInterObj){
            currentInterObj.SendMessage("DoInteraction");
        }
	}

    private void OnTriggerEnter2D(Collider2D other)
    {
        //Check para ver se o objeto esta proximo do player
        if (other.CompareTag("interObject")){
            currentInterObj = other.gameObject;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        //Reset para quando o player sai de perto do objeto
        if (other.CompareTag("interObject")){
            if (other.gameObject == currentInterObj){
                currentInterObj = null;
            }
        }
    }
}

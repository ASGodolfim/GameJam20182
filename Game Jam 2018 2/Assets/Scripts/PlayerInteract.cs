using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteract : MonoBehaviour {

    public GameObject currentInterObj = null;
    public ObjetoInterativel currentInterObjScript = null;
    public Bag bag;

    void Update() {
        //Envio da Interação com o objeto
        if (Input.GetButtonDown("Interact") && currentInterObj) {
            if (currentInterObjScript.baggable) {
                bag.AddItem(currentInterObj);
            }
            if (currentInterObjScript.openable) {
                if (currentInterObjScript.itemneeded) {
                    if (bag.Finditem(currentInterObjScript.ItemNeeded)) {
                        Debug.Log("cookie has been put on the "+currentInterObj);
                        //Play scene

                    } else {
                        Debug.Log("Fail");
                    }

                }

            }
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        //Check para ver se o objeto esta proximo do player
        if (other.CompareTag("interObject")){
            currentInterObj = other.gameObject;
            currentInterObjScript = currentInterObj.GetComponent<ObjetoInterativel>();
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

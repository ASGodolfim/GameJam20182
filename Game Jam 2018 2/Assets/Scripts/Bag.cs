using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bag : MonoBehaviour
{

    public GameObject[] bag = new GameObject[1];
    public PlayerInteract PI;

    bool itemAdded = false;

    public void AddItem(GameObject item)
    {
        //ver se pode ser guardado ou não
        for (int i = 0; i < bag.Length; i++)
        {
            if (bag[i] == null)
            {
                bag[i] = item;
                itemAdded = true;
                Debug.Log(item.name + "was added");
                item.SendMessage("DoInteraction");
            }
            else
            {
                Debug.Log("I cant carry anymore of those");
            }
        }
               
    }
    public bool Finditem(GameObject item)
    {
        //Achou o item
        if (bag[0] == item)
        {
            bag[0] = null;
            return true;
        }
        else
        {
            //não achou o item
            return false;
        }
    }
}
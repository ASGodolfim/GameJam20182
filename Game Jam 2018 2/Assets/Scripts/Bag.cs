using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bag : MonoBehaviour {

    public GameObject[] bag = new GameObject[1];

    public void AddItem(GameObject item){

        bool itemAdded = false;

        for (int i = 0; i < bag.Length; i++)
        {
            if (bag[i] == null)
            {
                bag[i] = item;
                Debug.Log(item.name + "was added");
                itemAdded = true;
                break;
                }
            }
         if (!itemAdded){
            Debug.Log("I cant carry anymore of those");
         }
    }
}
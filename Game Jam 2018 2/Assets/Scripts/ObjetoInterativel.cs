using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjetoInterativel : MonoBehaviour{

    public bool baggable;
    public bool openable;
    public bool itemneeded;
    public GameObject ItemNeeded;

    public void DoInteraction()
    {
        //Objeto sumir
        gameObject.SetActive (false);
    }

    void Start(){

    }

    void Update(){
    }
}

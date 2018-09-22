using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    private Rigidbody2D myRigidbody;
    public float Speed;     //Velocidade de movimento
    public float RunSpeed;    //Velocidade de corrida

	void Start () {
        myRigidbody = GetComponent<Rigidbody2D>();
	}

	void FixedUpdate() {        //Input para movimentação
        float horizontal = Input.GetAxis("Horizontal");
   
        HandleMovement(horizontal);
	}

    private void HandleMovement(float horizontal){

        bool Run = Input.GetKey(KeyCode.LeftShift);

        //Movimentação
        myRigidbody.velocity = new Vector2(horizontal * Speed , myRigidbody.velocity.y);

        //Corrida
        if (Run) {
            myRigidbody.velocity = new Vector2(horizontal * RunSpeed, myRigidbody.velocity.y);
        }

    }
}

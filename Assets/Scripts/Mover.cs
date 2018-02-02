using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour {

	// Use this for initialization
	void Start () {


        Rigidbody2D rbody = this.gameObject.GetComponent<Rigidbody2D>();
        rbody.velocity = new Vector2(2, 0);

	}
	
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class labTwoButtonClick : MonoBehaviour {

    
    public Rigidbody2D player;
    public Sprite sp;


    // Use this for initialization
    void Start()
    {
       
    }

    private void OnMouseDown()
    {
        SpriteRenderer sRend = player.GetComponent<SpriteRenderer>();
        sRend.sprite = sp;


    }

}

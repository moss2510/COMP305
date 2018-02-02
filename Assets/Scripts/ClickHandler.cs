using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickHandler : MonoBehaviour {

    //public int someNumber;
    public GameObject Moss;
    public Sprite newSprite;
    public Sprite firstSprite;
    public Sprite secondSprite;

    private Rigidbody2D rbody;
    private SpriteRenderer sRend;
    

    // Use this for initialization
    void Start () {
        //Debug.Log(someNumber);
        rbody = Moss.GetComponent<Rigidbody2D>();
        sRend = Moss.GetComponent<SpriteRenderer>();

        rbody.velocity = new Vector2(2, 0);
        
	}

    private void OnMouseDown()
    {
        //rbody = Moss.GetComponent<Rigidbody2D>();
        rbody.velocity *= -1;
        if(sRend.sprite == firstSprite)
        {
            sRend.sprite = secondSprite;
        }
        else
        {
            sRend.sprite = firstSprite;
        }
        

    }

}

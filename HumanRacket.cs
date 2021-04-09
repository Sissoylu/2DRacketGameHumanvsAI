using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HumanRacket : Racket
{
    public string axisName = "Vertical1";
    

    protected override void HareketEt()
    {
        float moveAxis = Input.GetAxis(axisName)*moveSpeed; //w->1, s->-1
        GetComponent<Rigidbody2D>().velocity = new Vector2(0,moveAxis); //x yönünde hareket yok y yönünde moveaxis kadar hareket
    }   
    

}

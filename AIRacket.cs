using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIRacket : Racket
{
    public Transform ball;
    protected override void HareketEt()
    {
        //topun raketle mesafesini hesaplayıp ona göre harekete başlamasını sağlamalıyız
        float distance = Mathf.Abs(ball.position.y - transform.position.y);
        if (distance > 4)
        {
                    //topun y pozisyonu yukarıdaysa
        if (ball.position.y > transform.position.y)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0,1) * moveSpeed;
            
        }
        else
        {
            //değilse -y konumunda hareket edecek
            GetComponent<Rigidbody2D>().velocity = new Vector2(0,-1) * moveSpeed;
        }
        }

    }

}

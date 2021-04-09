using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    public Racket leftRacket, rightRacket;
    Rigidbody2D rb2;
    public float moveSpeed=10;
    // Start is called before the first frame update
    void Start()
    {
        rb2 = gameObject.GetComponent<Rigidbody2D>();
        rb2.velocity = new Vector2(1,0)*moveSpeed; //ilk hız ataması x=1, y=0
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        TagManager tagManager = collision.gameObject.GetComponent<TagManager>();
        GetComponent<AudioSource>().Play();

        if (tagManager == null) return;

        Tag tag = tagManager.myTag;

        if (tag.Equals(Tag.SAG_DUVAR))
        {
            //sol raket skor
            leftRacket.makescore();

        }
        else if (tag == Tag.SOL_DUVAR)
        {
            //sağ raket skor
            rightRacket.makescore();
        }

        //top rakete çarptığı an
        if(tag.Equals(Tag.SAG_RAKET))
        {
            //topun ysi - raketin ysi
            float a = transform.position.y - collision.gameObject.transform.position.y;
            
            //raketin uzunluğu
            float b = collision.collider.bounds.size.y;
            
            float y = a/b;
            float x =  -1; //sağ raketten bahsediyorsak -1 olmalıdır -sonsuza 

            rb2.velocity = new Vector2(x,y)*moveSpeed;
            
        }
        else if (tag.Equals(Tag.SOL_RAKET))
        {
                        //topun ysi - raketin ysi
            float a = transform.position.y - collision.gameObject.transform.position.y;
            
            //raketin uzunluğu
            float b = collision.collider.bounds.size.y;
            
            float y = a/b;
            float x =  1; //sağ raketten bahsediyorsak -1 olmalıdır -sonsuza 

            rb2.velocity = new Vector2(x,y)*moveSpeed;
            


        }
    }

}

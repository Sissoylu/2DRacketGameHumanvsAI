using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public abstract class Racket : MonoBehaviour
{

    public float moveSpeed=10;
    public Text scoreText;
    public int Score {get; private set;}
    void Start()
    {
        
    }

    // Update is called once per frame


    void FixedUpdate()
    {
        HareketEt();
        
    }

    protected abstract void HareketEt();
 

    public void makescore()
    {
        Score++;
        scoreText.text = Score.ToString();
    }
}

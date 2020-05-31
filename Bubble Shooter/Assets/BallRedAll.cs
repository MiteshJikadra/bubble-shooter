using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallRedAll : MonoBehaviour
{
    public GameObject[] Red;
    
    
    
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag=="Red")
        {
            //Destroy(this.gameObject);
            Destroy(Red[0].gameObject);
            Destroy(Red[1].gameObject);
            Destroy(Red[2].gameObject);
            Destroy(Red[3].gameObject);
            Destroy(Red[4].gameObject);
            Destroy(Red[5].gameObject);
            Destroy(Red[6].gameObject);
            Destroy(Red[7].gameObject);
            Destroy(Red[8].gameObject);
            Destroy(Red[9].gameObject);
            Destroy(Red[10].gameObject);
            Destroy(Red[11].gameObject);
            Destroy(Red[12].gameObject);
            Destroy(Red[13].gameObject);
            Destroy(Red[14].gameObject);
            Destroy(Red[15].gameObject);
            Destroy(Red[16].gameObject);
            Destroy(Red[17].gameObject);
            Destroy(Red[18].gameObject);
            Destroy(Red[19].gameObject);
            Destroy(Red[20].gameObject);
            Destroy(Red[21].gameObject);
            Destroy(Red[22].gameObject);
            Destroy(Red[23].gameObject);
        }
        
       
        
    }
    public void RedBallUnfreez()
    {

    }
}

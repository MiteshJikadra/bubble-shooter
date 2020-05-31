using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallYellowAll : MonoBehaviour
{
    public GameObject[] Y1;
   
    //public GameObject Y2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Yellow")
        {
            //Destroy(this.gameObject);
            Destroy(Y1[0].gameObject);
            Destroy(Y1[1].gameObject);
            Destroy(Y1[2].gameObject);
            Destroy(Y1[3].gameObject);
            Destroy(Y1[4].gameObject);
            Destroy(Y1[5].gameObject);
            Destroy(Y1[6].gameObject);
            Destroy(Y1[7].gameObject);
            Destroy(Y1[8].gameObject);
            Destroy(Y1[9].gameObject);
            Destroy(Y1[10].gameObject);
            Destroy(Y1[11].gameObject);
            Destroy(Y1[12].gameObject);
            Destroy(Y1[13].gameObject);
            Destroy(Y1[14].gameObject);
            Destroy(Y1[15].gameObject);
            Destroy(Y1[16].gameObject);
            Destroy(Y1[17].gameObject);
            Destroy(Y1[18].gameObject);
            Destroy(Y1[19].gameObject);
            Destroy(Y1[20].gameObject);
            Destroy(Y1[21].gameObject);
            Destroy(Y1[22].gameObject);
            Destroy(Y1[23].gameObject);
            Destroy(Y1[24].gameObject);
            Destroy(Y1[25].gameObject);
            Destroy(Y1[26].gameObject);
            Destroy(Y1[27].gameObject);
            

            //Destroy(Y2.gameObject);

        }

    }
}

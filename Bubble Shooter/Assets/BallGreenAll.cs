using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallGreenAll : MonoBehaviour
{
    public GameObject[]Green;
    
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
        if (collision.gameObject.tag == "Green")
        {
            //Destroy(this.gameObject);
            Destroy(Green[0].gameObject);
            Destroy(Green[1].gameObject);
            Destroy(Green[2].gameObject);
            Destroy(Green[3].gameObject);
            Destroy(Green[4].gameObject);
            Destroy(Green[5].gameObject);
            Destroy(Green[6].gameObject);
            Destroy(Green[7].gameObject);
            Destroy(Green[8].gameObject);
            Destroy(Green[9].gameObject);
            Destroy(Green[10].gameObject);
            Destroy(Green[11].gameObject);
            Destroy(Green[12].gameObject);
            Destroy(Green[13].gameObject);
            Destroy(Green[14].gameObject);
            Destroy(Green[15].gameObject);
            Destroy(Green[16].gameObject);
            Destroy(Green[17].gameObject);
            Destroy(Green[18].gameObject);
            Destroy(Green[19].gameObject);
            Destroy(Green[20].gameObject);
            Destroy(Green[21].gameObject);
            Destroy(Green[22].gameObject);
            Destroy(Green[23].gameObject);

        }
    }
}

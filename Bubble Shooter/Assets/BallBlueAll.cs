using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBlueAll : MonoBehaviour
{
    public GameObject[] Blue;
    
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
        if (collision.gameObject.tag == "Blue")
        {
            //Destroy(this.gameObject);
            Destroy(Blue[0].gameObject);
            Destroy(Blue[1].gameObject);
            Destroy(Blue[2].gameObject);
            Destroy(Blue[3].gameObject);
            Destroy(Blue[4].gameObject);
            Destroy(Blue[5].gameObject);
            Destroy(Blue[6].gameObject);
            Destroy(Blue[7].gameObject);
            Destroy(Blue[8].gameObject);
            Destroy(Blue[9].gameObject);
            Destroy(Blue[10].gameObject);
            Destroy(Blue[11].gameObject);
            Destroy(Blue[12].gameObject);
            Destroy(Blue[13].gameObject);
            Destroy(Blue[14].gameObject);
            Destroy(Blue[15].gameObject);
            Destroy(Blue[16].gameObject);
            Destroy(Blue[17].gameObject);
            Destroy(Blue[18].gameObject);
            Destroy(Blue[19].gameObject);
            Destroy(Blue[20].gameObject);
            Destroy(Blue[21].gameObject);
            Destroy(Blue[22].gameObject);
            Destroy(Blue[23].gameObject);

        }
    }
}

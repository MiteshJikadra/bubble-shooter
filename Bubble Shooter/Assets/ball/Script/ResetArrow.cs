using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetArrow : MonoBehaviour
{
    public static ResetArrow RA;
    private void Awake()
    {
        RA = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void DistroyDirection()
    {
        Destroy(this.gameObject);
    }
}

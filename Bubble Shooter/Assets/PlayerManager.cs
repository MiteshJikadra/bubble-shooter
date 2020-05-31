using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public GameObject[] PlayerPrefeb;
    public static PlayerManager PM;
    //public Transform pos;
    // Start is called before the first frame update

    private void Awake()
    {
        PM = this;
    }
    void Start()
    {
        BallGendrate();
        StartCoroutine(Ball());
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetMouseButtonUp(0))
        {
            BallGendrate();
            StartCoroutine(Ball());

        }
    }
    public void BallGendrate()
    {
       
    }
    IEnumerator Ball()
    {
        yield return new WaitForSeconds(1f);
        int p = Random.Range(0, 4);
        Instantiate(PlayerPrefeb[p], transform.position, Quaternion.identity);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballmove : MonoBehaviour
{
    private Rigidbody2D rb;
    public float thrust;
    private float degress = 0;
    private Vector3 mouseCurrentPos;//current mouse pos
    private Vector3 mousePreviousPos;
    public float RotateSpeed = 5;
    private float m_degress = 0;
    private Vector3 m_CurrPos;
    //public float R = 2.4f;
    private Vector3 moveDirection;
    //public float ZSpeed = 30;
    
    //public CharacterController characterController;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }
    

    // Update is called once per frame
    private void FixedUpdate()
    {
        if (Input.GetMouseButtonUp(0))
        {
            
            rb.AddForce(transform.up * thrust);
            ResetArrow.RA.DistroyDirection();
            Debug.Log("erroe");
        }
        //if (GameManager.Instacne.GameState != GameStateEnum.StartGame)
        //    return;
        degress = 0;
        
        if (Input.GetMouseButtonDown(0))
        {
            mouseCurrentPos = mousePreviousPos = Camera.main.ScreenToViewportPoint(Input.mousePosition);
        }
        else if (Input.GetMouseButton(0))
        {
            //calculate the degress each frame when the finger swipe
            mouseCurrentPos = Camera.main.ScreenToViewportPoint(Input.mousePosition);
            float deltaMousePos = (mouseCurrentPos.x - mousePreviousPos.x);
            float sign = Mathf.Sign(deltaMousePos);
            float speed = Mathf.Abs(deltaMousePos * 200);

            speed = Mathf.Clamp(speed, 0, RotateSpeed);
            speed *= -sign;
            degress = speed;
            mousePreviousPos = mouseCurrentPos;
           
        }

       

        m_degress += degress;
        if (m_degress >= 90)
            m_degress -= 90;
        degress = degress / 90 * Mathf.PI;
        Vector2 temp = new Vector2(transform.position.x, transform.position.y);
        Vector2 pos = temp.normalized;
        //calculate the new position ,when ball rotate degress angle.
        float x = pos.x * Mathf.Cos(degress) - pos.y * Mathf.Sin(degress);
        float y = pos.x * Mathf.Sin(degress) + pos.y * Mathf.Cos(degress);
        m_CurrPos = new Vector3(x, y, 0);
        //calculate the movement of ball each frame
        moveDirection = m_CurrPos - transform.position;

      
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, m_degress));
        
    }
   
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Blue")
        {
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
        }
        
        if (collision.gameObject.tag == "Green")
        {
            StartCoroutine(ti());
        }
        
        if (collision.gameObject.tag == "Yellow")
        {
            StartCoroutine(ti());
        }
        
        if (collision.gameObject.tag == "Red")
        {
            StartCoroutine(ti());
        }
        if (collision.gameObject.tag == "Empty")
        {
            StartCoroutine(ti());
        }

    }
    IEnumerator ti()
    {
        yield return new WaitForSeconds(0.001f);
        gameObject.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezePositionY;
    }

}

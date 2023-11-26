using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class xd : MonoBehaviour
{
    public float SpeedY;
    public int DirectionX;
    public int DirectionY;
    public float SpeedX;
    private float Horizontal;
    private float Vertical;
    private Rigidbody2D _compRigidbody;
    // Start is called before the first frame update
    private void Awake()
    {
        _compRigidbody = GetComponent<Rigidbody2D>();
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Horizontal = Input.GetAxis("Horizontal");
        Vertical = Input.GetAxis("Vertical");
        transform.position = new Vector2(transform.position.x + Horizontal* SpeedX * Time.deltaTime, transform.position.y + Vertical * SpeedY * Time.deltaTime);
    }
    private void FixedUpdate()
    {
       // _compRigidbody.velocity = new Vector2(SpeedX * DirectionX, SpeedY * DirectionY);

    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Man")
        {
            if (DirectionX == 1)
            {
                DirectionX = -1;
            }
            else if (DirectionX == -1)
            {
                DirectionX = 1;
            }
        }
        if (collision.gameObject.tag == "Mon")
        {
            if (DirectionY == 1)
            {
                DirectionY = -1;
            }
            else if (DirectionY == -1)
            {
                DirectionY = 1;
            }
        }
    }
}

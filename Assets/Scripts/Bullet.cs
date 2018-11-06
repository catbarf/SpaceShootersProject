using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Rigidbody2D _rigidbody2D;
    public float speed = 20f;
    public bool right = true;


    private void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (right)
        {
            _rigidbody2D.AddForce(new Vector2(speed, 0));
        }
        else
        {
            _rigidbody2D.AddForce(new Vector2(-speed, 0));
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
        {
            collision.GetComponent<Enemy>().health--;
            Destroy(gameObject);
        }
    }
}
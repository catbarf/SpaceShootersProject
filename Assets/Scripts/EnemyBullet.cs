using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour {

    private Rigidbody2D _rigidbody2D;
    public float speed = 20f;
    public bool right = false;
    public bool fidgetSpinner;
    private Vector2 direction;


    private void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        direction = transform.parent.transform.up;
    }

    void Update()
    {
        if (!fidgetSpinner)
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
        else
        {
            _rigidbody2D.AddForce(direction);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            collision.GetComponent<Player>().health--;
            Destroy(gameObject);
        }
    }
}

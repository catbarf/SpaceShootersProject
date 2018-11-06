using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public float flyingSpeed = 15;
    public int health = 3;

    private float horizontal;
    private float vertical;

    private float maxVertical = 4;
    private float minVertical = -4;
    private float maxHorizontal = -4;
    private float minHorizontal = -7;

    private void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        if (transform.localPosition.y < maxVertical && transform.localPosition.y > minVertical)
        {
            transform.Translate(Vector2.left / 100 * flyingSpeed * vertical);
        }
        else if (transform.localPosition.y > maxVertical - 1f)
        {
            transform.Translate(Vector2.left / 100 * flyingSpeed * -0.05f);
        }
        else if (transform.localPosition.y > minVertical - 1f)
        {
            transform.Translate(Vector2.left / 100 * flyingSpeed * 0.05f);
        }


        if (transform.localPosition.x < maxHorizontal && transform.localPosition.x > minHorizontal)
        {
            transform.Translate(Vector2.up / 100 * flyingSpeed * horizontal);
        }
        else if ((transform.localPosition.x > maxHorizontal - 1f) || horizontal < 0)
        {
            transform.Translate(Vector2.up / 100 * flyingSpeed * (-1 + -horizontal));
        }
        else if ((transform.localPosition.x > minHorizontal - 1f) || horizontal > 0)
        {
            transform.Translate(Vector2.up / 100 * flyingSpeed * (1 + horizontal));
        }
        else
        {
            transform.Translate(Vector2.up / 100 * flyingSpeed * 0.1f);
        }
    }
}

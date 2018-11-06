using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {

    public int health = 10;
    public bool canBeDamaged = true;

    private SpriteRenderer sr;

    private void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        if (health <= 0)
        {
            Destroy(gameObject);
            SceneManager.LoadScene("GameOver");
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            if (canBeDamaged)
            {
                canBeDamaged = false;
                health -= collision.GetComponent<Enemy>().damage;
                StartCoroutine(DamageBlink());
            }
        }
    }


    private IEnumerator DamageBlink()
    {

        for (int i = 0; i < 4; i++)
        {
            sr.color = new Color(1, 0, 0, 0.5f);
            yield return new WaitForSeconds(0.25f);
            sr.color = new Color(1, 1, 1, 1);
            yield return new WaitForSeconds(0.25f);
        }
        canBeDamaged = true;
    }
}

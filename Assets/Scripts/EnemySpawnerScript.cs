using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnerScript : MonoBehaviour
{

    public GameObject[] enemies;
    private float spawnCooldown = 5;
    public float difficulty = 0.01f;

    private void Start()
    {
        StartCoroutine(Spawn(spawnCooldown - difficulty));
    }

    IEnumerator Spawn(float spawnCooldown)
    {
        yield return new WaitForSeconds(spawnCooldown);
        if (Data.score >= 60)
        {
            GameObject clone = Instantiate(enemies[6], transform.parent);
            clone.transform.position = transform.position + new Vector3(0, Random.Range(-transform.localScale.y - 3, transform.localScale.y + 3));
        }
        if (Data.score >= 50)
        {
            GameObject clone = Instantiate(enemies[5], transform.parent);
            clone.transform.position = transform.position + new Vector3(0, Random.Range(-transform.localScale.y - 3, transform.localScale.y + 3));
        }
        else if (Data.score >= 40)
        {
            GameObject clone = Instantiate(enemies[4], transform.parent);
            clone.transform.position = transform.position + new Vector3(0, Random.Range(-transform.localScale.y - 3, transform.localScale.y + 3));
        }
        else if (Data.score >= 30)
        {
            GameObject clone = Instantiate(enemies[3], transform.parent);
            clone.transform.position = transform.position + new Vector3(0, Random.Range(-transform.localScale.y - 3, transform.localScale.y + 3));
        }
        else if (Data.score >= 20)
        {
            GameObject clone = Instantiate(enemies[2], transform.parent);
            clone.transform.position = transform.position + new Vector3(0, Random.Range(-transform.localScale.y - 3, transform.localScale.y + 3));
        }
        else if (Data.score >= 10)
        {
            GameObject clone = Instantiate(enemies[1], transform.parent);
            clone.transform.position = transform.position + new Vector3(0, Random.Range(-transform.localScale.y - 3, transform.localScale.y + 3));
        }
        else
        {
            GameObject clone = Instantiate(enemies[0], transform.parent);
            clone.transform.position = transform.position + new Vector3(0, Random.Range(-transform.localScale.y - 3, transform.localScale.y + 3));
        }

        difficulty += 0;
        StartCoroutine(Spawn(spawnCooldown - difficulty));
    }
}
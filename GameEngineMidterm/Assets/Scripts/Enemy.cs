using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Tank
{
    [SerializeField] public GameObject enemyBulletPrefab;
    float moveTimer = 0;
    float moveDelay = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Die()
    {
        foreach (Observer observer in observers)
        {
            observer.Notify();
        }
        Destroy(gameObject);
    }

    private void FixedUpdate()
    {
        moveTimer -= Time.fixedDeltaTime;
        if (moveTimer < 0)
        {
            moveTimer = moveDelay;
            if (Random.Range(0, 2) == 1)
            {
                Move(new Vector2(Mathf.Sign(0.5f - Random.Range(0, 2)) * 1, 0));
            }
            else
            {
                Move(new Vector2(0, Mathf.Sign(0.5f - Random.Range(0, 2)) * 1));
            }
            Shoot(enemyBulletPrefab, new Vector2(0, -1));
        }
    }
}

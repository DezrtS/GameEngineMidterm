using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public virtual void Fire(Vector2 direction)
    {
        GetComponent<Rigidbody2D>().velocity =  5 * direction;
    }

    public virtual void Hit(Collider2D collision)
    {
        if (collision.CompareTag("Base"))
        {
            Player.Instance.KillPlayer();
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.gameObject.name);
        Hit(collision);
    }
}

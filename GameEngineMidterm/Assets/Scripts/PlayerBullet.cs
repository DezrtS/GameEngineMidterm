using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet : Bullet
{
    public override void Hit(Collider2D collision)
    {
        base.Hit(collision);
        if (collision.CompareTag("Enemy"))
        {
            collision.GetComponent<Enemy>().Die();
            Destroy(gameObject);
        }
    }
}

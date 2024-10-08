using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : Bullet
{
    public override void Hit(Collider2D collision)
    {
        base.Hit(collision);
        if (collision.CompareTag("Player"))
        {
            Player.Instance.TakeDamage();
            Destroy(gameObject);
        }
    }
}

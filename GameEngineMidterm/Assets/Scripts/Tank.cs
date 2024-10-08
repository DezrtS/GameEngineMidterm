using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank : Subject
{
    [SerializeField] float speed = 5;

    protected void Move(Vector2 direction)
    {
        Vector3 newPos = transform.position + speed * new Vector3(direction.x, direction.y);
        if (Mathf.Abs(newPos.x) != 9 && Mathf.Abs(newPos.y) != 5)
        {
            //transform.LookAt(newPos);
            transform.position = newPos;
        }
    }

    public void Shoot(GameObject bulletPrefab, Vector2 direction)
    {
        GameObject bullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
        Bullet bulletRig = bullet.GetComponent<Bullet>();
        bulletRig.Fire(direction);
       
    }
}

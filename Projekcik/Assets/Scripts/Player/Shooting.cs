using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
   /* public GameObject bullet;
    public GameObject player;
    public bool gun = false;
    public float bulletForce = 10f;
    public Rigidbody2D rb1;

    Vector2 mousePos;

    void Start()
    {
        
    }

    void Update()
    {
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 lookDir = mousePos - rb1.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x * Mathf.Rad2Deg - 90f);
        rb1.rotation = angle;
        if (gun)
        {
            if(Input.GetButtonDown("Fire1")&&player.GetComponent<PlayerSC>().energyCells > 0)
            {
                Shoot();
            }
        }
    }

    void Shoot()
    {
        GameObject newBullet = Instantiate(bullet, rb1.transform.position, rb1.transform.rotation);
        Rigidbody2D rb = newBullet.GetComponent<Rigidbody2D>();
        rb.AddForce(rb1.transform.up * bulletForce, ForceMode2D.Impulse);
    }

    public void TakeGun()
    {
        gun = !gun;
    }*/
}

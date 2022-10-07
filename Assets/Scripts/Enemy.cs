using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public bool indestructible = false;
    public float knockback = 10f;
    public float life = 1;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    protected void OnTriggerEnter2D(Collider2D collider)
    {
        Player player = collider.gameObject.GetComponent<Player>();
        if (player != null)
        {
            player.Hit(knockback, gameObject);
        }
    }

    public void Hit()
    {
        life -= 1;
        if (!indestructible && life<=0)
        {
            Destroy(gameObject);
        }
    }
}

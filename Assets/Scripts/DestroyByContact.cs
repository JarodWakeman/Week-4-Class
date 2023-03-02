using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByContact : MonoBehaviour
{
    public GameObject explosion;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Instantiate(explosion, transform.position, transform.rotation);
        Destroy(collision.gameObject);
        Destroy(this.gameObject);
        
    }
}

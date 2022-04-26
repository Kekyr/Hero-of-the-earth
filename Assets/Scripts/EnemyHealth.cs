using System;
using UnityEngine;
using UnityEngine.Serialization;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] private Bar _bar;
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.gameObject.name);
        if (collision.gameObject.layer == LayerMask.NameToLayer("Player bullets"))
        {
            _bar.ReduceAmountOfHealth(collision.gameObject.GetComponent<Projectile>().AmountOfDamage);
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.layer == LayerMask.NameToLayer("Player"))
        {
            Destroy(collision.gameObject);
        }
    }
}

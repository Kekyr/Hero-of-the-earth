using System;
using UnityEngine;
using UnityEngine.Serialization;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] private Bar _bar;
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        _bar.ReduceAmountOfHealth(collision.gameObject.GetComponent<Projectile>().AmountOfDamage);
        Destroy(collision.gameObject);
    }
}

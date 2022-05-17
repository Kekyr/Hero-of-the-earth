using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] private Bar _bar;
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Player bullets"))
        {
            _bar.ReduceAmountOfHealth(collision.gameObject.GetComponent<Projectile>().AmountOfDamage);
            collision.gameObject.SetActive(false);
        }
        
    }
}

using UnityEngine;

public class Projectile:MonoBehaviour
{
    [SerializeField] private float _amountOfDamage;
    
    public float AmountOfDamage
    {
        get => _amountOfDamage;
    }
}

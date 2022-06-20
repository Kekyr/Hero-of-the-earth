using System.Collections;
using UnityEngine;
using Random = UnityEngine.Random;

public class Bar : MonoBehaviour
{
    [SerializeField] private GameObject _healthBar;
    [SerializeField] private GameObject _powerUpPrefab;
    private GameObject _mainObject;
    
    private Vector2 _offset = new Vector2(0.25f, -0.6f);
    private float _amountOfHealth = 1;

    private void Start()
    {
        _mainObject = GetComponentInParent<EnemyHealth>().gameObject;
    }
    
    public void ReduceAmountOfHealth(float amountOfDamage)
    {
        _healthBar.SetActive(true);
        ModifyAmountOfDamage(ref amountOfDamage);
        _amountOfHealth -= amountOfDamage;
        if (_amountOfHealth <= 0)
        {
            SpawnPowerUp();
            Destroy(_mainObject);
        }
        else
        {
            transform.localScale = new Vector3(_amountOfHealth, 1, 1);
            Delay();
        }
        
    }

    private void SpawnPowerUp()
    {
        if (Random.value <= 0.1)
        {
            Vector3 position = new Vector3(transform.position.x + _offset.x, transform.position.y + _offset.y,
                _powerUpPrefab.transform.position.z);
            ObjectPooler.instance.SpawnFromPool("PowerUp", position, Quaternion.identity);
        }

    }

    private void ModifyAmountOfDamage(ref float amountOfDamage)
    {
        amountOfDamage/=100;
    }

    private void Delay()
    {
        StopCoroutine("DelayCoroutine");
        StartCoroutine(DelayCoroutine());
    }

    private IEnumerator DelayCoroutine()
    {
        yield return new WaitForSeconds(2f);
        _healthBar.SetActive(false);
    }
}

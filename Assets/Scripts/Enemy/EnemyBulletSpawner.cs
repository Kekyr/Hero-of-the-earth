using System.Collections;
using UnityEngine;
using Random = UnityEngine.Random;

public class EnemyBulletSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _exclamationMark;
    

    private void Start()
    {
        // Repeatrate from 9 to 50
        int repeatRate = Random.Range(9, 20);
        InvokeRepeating("Fire", 0f, repeatRate);
    }

    private void Fire()
    {
        StartCoroutine("Delay");
    }

    private IEnumerator Delay()
    {
        if (Random.value <= 0.1f)
        {
            for (var i = 0; i < 3; i++)
            {
                _exclamationMark.SetActive(true);
                yield return new WaitForSeconds(1f);
                _exclamationMark.SetActive(false);
                yield return new WaitForSeconds(1f);
            }

            ObjectPooler.instance.SpawnFromPool("Enemy Bullet", transform.position, Quaternion.identity);
        }
    }
}
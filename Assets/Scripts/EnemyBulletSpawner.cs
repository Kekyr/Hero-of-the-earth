using System.Collections;
using UnityEngine;

public class EnemyBulletSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _exclamationMark;

    private void Start()
    {
        //InvokeRepeating("Fire", 0f, 3f);
        StartCoroutine("Delay");
    }

    private void Fire()
    {
        StartCoroutine("Delay");
    }

    private IEnumerator Delay()
    {
        for (int i = 0; i < 3; i++)
        {
            _exclamationMark.SetActive(true);
            yield return new WaitForSeconds(1f);
            _exclamationMark.SetActive(false);
            yield return new WaitForSeconds(1f);
        }
        
        ObjectPooler.instance.SpawnFromPool("Enemy Bullet", transform.position, Quaternion.identity);
    }
}
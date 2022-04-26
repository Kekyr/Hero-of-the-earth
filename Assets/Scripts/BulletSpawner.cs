using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class BulletSpawner : MonoBehaviour
{
    [SerializeField] private string[] _poolTags;
    private int _currentPoolTagIndex = 0;

    private void Start()
    {
        Application.targetFrameRate = 80;
        InvokeRepeating("Fire", 0f, 0.6f);
    }

    private void Fire()
    {
        //Instantiate(_bulletPrefabs[_currentBulletPrefabIndex], transform.position, Quaternion.identity);
        ObjectPooler.instance.SpawnFromPool(_poolTags[_currentPoolTagIndex], transform.position,Quaternion.identity);
    }

    public void ChangePoolTag()
    {
        if (_currentPoolTagIndex + 1 < _poolTags.Length)
        {
            _currentPoolTagIndex++;
        }
    }
}
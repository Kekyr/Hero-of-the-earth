using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class BulletSpawner : MonoBehaviour
{
     [SerializeField] private GameObject[] _bulletPrefabs;
    private int _currentBulletPrefabIndex=0;

    private void Start()
    {
        Application.targetFrameRate = 80;
        InvokeRepeating("Fire",0f,0.6f);
    }

    private void Fire()
    {
        Instantiate(_bulletPrefabs[_currentBulletPrefabIndex],transform.position, Quaternion.identity);
    }

    public void ChangeBulletPrefab()
    {
        if (_currentBulletPrefabIndex+1 < _bulletPrefabs.Length)
        {
            _currentBulletPrefabIndex++;
        }
    }
}

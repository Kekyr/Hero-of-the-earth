﻿using System.Collections;
using UnityEngine;

public class Bar : MonoBehaviour
{
    [SerializeField] private GameObject _healthBar;
    private GameObject _mainObject;

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
            Destroy(_mainObject);
        }
        else
        {
            transform.localScale = new Vector3(_amountOfHealth, 1, 1);
            Delay();
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

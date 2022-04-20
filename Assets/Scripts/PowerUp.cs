using UnityEngine;

public class PowerUp : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collider)
    {
        Debug.Log(collider.gameObject.name);
        collider.gameObject.transform.GetComponentInChildren<BulletSpawner>().ChangeBulletPrefab();
        Destroy(gameObject);
    }
}

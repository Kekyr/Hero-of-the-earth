using UnityEngine;

public class PowerUp : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collider)
    {
        GameObject player = collider.gameObject;
        player.transform.GetComponentInChildren<BulletSpawner>().ChangePoolTag();
        Destroy(gameObject);
    }
}

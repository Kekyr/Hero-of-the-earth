using UnityEngine;

public class PowerUp : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collider)
    {
        Debug.Log(collider.gameObject.name);
        GameObject player = collider.gameObject;
        player.transform.GetComponentInChildren<BulletSpawner>().ChangePoolTag();
        Destroy(gameObject);
    }
}

using UnityEngine;

public class PowerUp : MonoBehaviour
{
    [SerializeField] private Vector2 _force=new Vector2(0,-1);
    private Rigidbody2D _rigidBody;
    
    
    private void Start()
    {
        _rigidBody=GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        _rigidBody.AddForce(_force);
    }
    
    private void OnTriggerEnter2D(Collider2D collider)
    {
        GameObject player = collider.gameObject;
        player.transform.GetComponentInChildren<BulletSpawner>().ChangePoolTag();
        //Destroy(gameObject);
        gameObject.SetActive(false);
    }
}

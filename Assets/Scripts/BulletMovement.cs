using UnityEngine;

public class BulletMovement : MonoBehaviour, IPooledObject
{
    [SerializeField] private Vector2 _force=new Vector2(0,1);
    private Rigidbody2D _rigidBody;
    
    
    private void Start()
    {
        _rigidBody = GetComponent<Rigidbody2D>();
    }
    
    private void Update()
    {
        _rigidBody.AddForce(_force);
    }

    public void OnObjectSpawn()
    {
        if (_rigidBody != null)
        {
            _rigidBody.velocity = Vector2.zero;
        }
    }
}

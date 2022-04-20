using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    private Rigidbody2D _rigidBody;
    [SerializeField] private Vector2 _force=new Vector2(0,1);
    
    void Start()
    {
        _rigidBody = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        _rigidBody.AddForce(_force);
    }
}

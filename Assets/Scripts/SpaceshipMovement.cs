using UnityEngine;

public class SpaceshipMovement : MonoBehaviour
{
    [SerializeField]
    private float thrustForce = 5f;
    [SerializeField]
    private float rotationSpeed;

    private Rigidbody2D body;

    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            body.AddForce(transform.right * thrustForce);
        }
        if (Input.GetKey(KeyCode.A))
        {
            body.rotation += rotationSpeed * Time.fixedDeltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            body.rotation -= rotationSpeed * Time.fixedDeltaTime;
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawSphere(transform.position, 0.1f);
        Gizmos.color = Color.blue;
        Gizmos.DrawSphere(transform.position + transform.right * 2, 0.1f);
    }
}

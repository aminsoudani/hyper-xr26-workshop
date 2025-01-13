using UnityEngine;

public class SpaceshipMovement : MonoBehaviour
{
    private Rigidbody2D body;

    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            body.AddForce(transform.right);
        }
        if (Input.GetKey(KeyCode.E))
        {
            body.AddRelativeForce(Vector2.right);
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

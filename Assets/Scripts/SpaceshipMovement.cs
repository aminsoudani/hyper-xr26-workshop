using UnityEngine;

public class SpaceshipMovement : MonoBehaviour
{
    [SerializeField]
    private float thrustForce = 5f;
    [SerializeField]
    private float rotationSpeed;
    [SerializeField]
    private Sprite idleSprite;
    [SerializeField]
    private Sprite thrustSprite;
    [SerializeField]
    private float thrustBlinkFrequency;

    private SpriteRenderer spriteRenderer;
    private Rigidbody2D body;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
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

    private void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            spriteRenderer.sprite = thrustSprite;
        }
        else
        {
            spriteRenderer.sprite = idleSprite;
        }
    }
}

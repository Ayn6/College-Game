using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public Rigidbody2D rb;
    public float walkSpeed;
    public float runSpeed;
    private float nowSpeed; 
    private Vector2 moveVector;

    void Start()
    {
        nowSpeed = walkSpeed;

    }

    private void FixedUpdate()
    {
        moveVector.x = Input.GetAxis("Horizontal");
        moveVector.y = Input.GetAxis("Vertical");
        rb.MovePosition(rb.position + moveVector * nowSpeed * Time.deltaTime);

        if(Input.GetKey(KeyCode.LeftShift))
        {
            nowSpeed = runSpeed;
            
        }
        else
        {
            nowSpeed = walkSpeed;
        }
    }
}

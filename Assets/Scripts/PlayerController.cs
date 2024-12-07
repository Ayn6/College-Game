using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public Rigidbody2D rb;
    public float walkSpeed;
    public float runSpeed;
    private float nowSpeed; 
    private Vector2 moveVector;
    public float stamina = 5;
   
    void Start()
    {
        nowSpeed = walkSpeed;
       

    }
    private void FixedUpdate()
    {
        moveVector.x = Input.GetAxis("Horizontal");
        moveVector.y = Input.GetAxis("Vertical");
        rb.MovePosition(rb.position + moveVector * nowSpeed * Time.deltaTime);

        if(Input.GetKey(KeyCode.LeftShift) && stamina > 0)
        {
            stamina -= Time.deltaTime;
            nowSpeed = runSpeed;
            
        }
        if(!(Input.GetKey(KeyCode.LeftShift) && stamina > 0))
        {
            stamina += Time.deltaTime;
            nowSpeed = walkSpeed;
        }
        if (stamina >= 5) stamina = 5;
        if (stamina <= 0) stamina = 0;
        
        
    }

}

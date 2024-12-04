using UnityEngine;

public class TetsSqare : MonoBehaviour
{
    
    public float speed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0, -speed, 0) * Time.deltaTime;
    }
    
}
using UnityEngine;

public class Charactermove : MonoBehaviour
{
    public float speed = 5f;
    public Rigidbody rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        transform.position += new Vector3(horizontal * speed * Time.deltaTime, 0, 0);
        transform.position += new Vector3(0, 0, vertical * speed * Time.deltaTime);
        Jump();
    }


    public void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * speed, ForceMode.Impulse);
        } 

        /*
        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * speed, ForceMode.Impulse);
        } */
    }
}

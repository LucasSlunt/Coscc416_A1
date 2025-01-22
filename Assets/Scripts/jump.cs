using UnityEngine;

public class jump : MonoBehaviour
{
    public Rigidbody sphereRigidBody;
    public float jumpSpeed =20f;
    public bool isInAir;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        isInAir = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space) & isInAir == false) //jumping
        {
            sphereRigidBody.AddForce(0, jumpSpeed, 0);
            isInAir = true;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        isInAir = false;
        Debug.Log("collision detected");
    }
}

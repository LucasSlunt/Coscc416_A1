using JetBrains.Annotations;
using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public Rigidbody sphereRigidBody;
    public float ballSpeed = 2f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 inputVector = Vector2.zero;
        if (Input.GetKey(KeyCode.W))
        {
            inputVector += Vector2.up; //adds the "up" vector, [0,1]
        }
        if (Input.GetKey(KeyCode.S))
        {
            inputVector += Vector2.down;
        }
        if (Input.GetKey(KeyCode.A))
        {
            inputVector += Vector2.left;
        }
        if (Input.GetKey(KeyCode.D))
        {
            inputVector += Vector2.right;
        }
        Debug.Log("Resultant Vector = " + inputVector);
        //each frame we get a 2D vector representing the current inputs
        //we want a 3D vector so we can apply it to our 3D object
        Vector3 inputXZPlane = new Vector3(inputVector.x, 0, inputVector.y);
        //this maps our 2d input to a 3d force vector.
        sphereRigidBody.AddForce(ballSpeed*inputXZPlane);
        //you can multiply vectors in unity just like in regular math

    }
}

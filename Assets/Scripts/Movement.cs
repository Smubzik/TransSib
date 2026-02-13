using UnityEngine;

public class Movement : MonoBehaviour
{

    private Rigidbody2D rb;

    private void Awake()
    {
         rb = GetComponent<Rigidbody2D>();   
    }
    private void Update()
    {
        Vector2 inputVector = new Vector2(0, 0);

        if (Input.GetKey(KeyCode.W)) {
            inputVector.y = 1f;
        }
        if (Input.GetKey(KeyCode.S))
        {
            inputVector.y = -1f;
        }
        if (Input.GetKey(KeyCode.A))
        {
            inputVector.x = -1f;
        }
        if (Input.GetKey(KeyCode.D))
        {
            inputVector.x = 1f;
        }

        Debug.Log(inputVector);
        rb.MovePosition(rb.position + inputVector);
    }
}

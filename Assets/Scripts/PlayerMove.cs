using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private float horiziontalInput;
    private float verticalInput;

    private float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        PlayerMovement();

    }


    private void PlayerMovement()
    {
        horiziontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector2.right * speed * Time.deltaTime * horiziontalInput);
        transform.Translate(Vector2.up * speed * Time.deltaTime * verticalInput);
    }
}

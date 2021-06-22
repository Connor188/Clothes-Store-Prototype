using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private float horiziontalInput;
    private float verticalInput;

    private Animator playerAnim;

    private float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        playerAnim = GetComponentInChildren<Animator>();
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

        if (horiziontalInput > Mathf.Abs(0) || verticalInput > Mathf.Abs(0) || horiziontalInput < Mathf.Abs(0) || verticalInput < Mathf.Abs(0))
        {
            playerAnim.SetBool("Walking", true);
        }
        else
        {
            playerAnim.SetBool("Walking", false);
        }
        

        
    }
}

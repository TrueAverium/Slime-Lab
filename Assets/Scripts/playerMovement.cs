using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{

    private Rigidbody rb;
    float currentspeed;

    
    [SerializeField] float playerSpeed;
    // Start is called before the first frame update
    void Start()
    {
        currentspeed = playerSpeed;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal"); //A-D buttons
        float vertical = Input.GetAxis("Vertical"); //W-S buttons

        Vector3 dir = new Vector3(horizontal, 0, vertical);

        rb.velocity = dir * currentspeed;
    }
}

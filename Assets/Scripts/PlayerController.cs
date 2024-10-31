using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed=10f;
    public float TurnSpeed=5f;
    private float HorizontalInput;
    private float VerticalInput;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        HorizontalInput = Input.GetAxis("Horizontal");
        VerticalInput = Input.GetAxis("Vertical");
        if(HorizontalInput != 0 || VerticalInput != 0)
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed * VerticalInput);
            transform.Rotate(Vector3.up*Time.deltaTime*TurnSpeed*HorizontalInput);
        }
        

    }
}

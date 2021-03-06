using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float power = 1;
    public Rigidbody rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //upキー入力   
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rigidbody.AddForce(new Vector3(0, 0, 2) * power);
        }

        //leftキー入力
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rigidbody.AddForce(new Vector3(-2, 0, 0) * power);
        }

        //rightキー入力
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rigidbody.AddForce(new Vector3(2, 0, 0) * power);
        }

        //downキー入力
        if (Input.GetKey(KeyCode.DownArrow))
        {
            rigidbody.AddForce(new Vector3(0, 0, -2) * power);
        }
    }
}

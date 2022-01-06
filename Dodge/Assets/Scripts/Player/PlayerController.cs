using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float Speed = 4.0f;

    private Rigidbody _rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //축에대해 입력을 받음
        float xInput = Input.GetAxis("Horizontal");
        float zInput = Input.GetAxis("Vertical");

        float xSpeed = xInput * Speed;
        float zSpeed = zInput * Speed;

        Vector3 newVelocity = new Vector3(xSpeed, 0f, zSpeed);

        _rigidbody.velocity = newVelocity;

        ////가속도 있음
        //if(Input.GetKey(KeyCode.UpArrow))
        //{
        //    _rigidbody.AddForce(0f, 0f, Speed);
        //}

        //if (Input.GetKey(KeyCode.DownArrow))
        //{
        //    _rigidbody.AddForce(0f, 0f, -Speed);
        //}

        //if (Input.GetKey(KeyCode.LeftArrow))
        //{
        //    _rigidbody.AddForce(-Speed, 0f, 0f);
        //}

        //if (Input.GetKey(KeyCode.RightArrow))
        //{
        //    _rigidbody.AddForce(Speed, 0f, 0f);
        //}
    }

    public void Die()
    {
        //현재 스크립트를 들고있는 게임 오브젝트
        gameObject.SetActive(false);
    }
}

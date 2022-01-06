using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public float Speed = 8f;

    private Rigidbody _rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        //GetComponenet<Rigidbody>().AddForce(-400f, 0f, 0f);
        _rigidbody = GetComponent<Rigidbody>();

        _rigidbody.velocity = transform.forward * Speed;

        Destroy(gameObject, 3f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter(UnityEngine.Collider other)
    {
        if(other.tag == "Player")
        {
            //var playerController = other.GetComponent<PlayerController>();
            //if(playerController != null)
            //{
            //    playerController.Die();
            //}
            //°°Àº°Í
            other.GetComponent<PlayerController>()?.Die();
        }
    }

}

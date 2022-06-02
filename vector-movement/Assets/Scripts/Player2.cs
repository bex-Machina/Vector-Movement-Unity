using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour
{
    // Start is called before the first frame update
    new Rigidbody rigidbody;
    Vector3 velocity;
    float speed = 7f;
    int coinCount;
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 input = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
        Vector3 direction = input.normalized;
        velocity = direction * speed; 
    }

    private void FixedUpdate()
    {
        rigidbody.position += velocity * Time.fixedDeltaTime;
    }

    private void OnTriggerEnter(Collider item)
    {
        if(item.gameObject.tag == "Coin")
        {
            Destroy(item.gameObject);
            coinCount++;
        }
    }
}

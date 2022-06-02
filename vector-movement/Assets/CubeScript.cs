using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour
{
    public Transform Spher;
    private void Start()
    {
        Spher.parent = transform;
    }
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * Time.deltaTime * 180,Space.World);
        transform.Translate(Vector3.forward * Time.deltaTime * 7,Space.World);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Spher.position = Vector3.zero;
        }
    }
}

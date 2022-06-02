using UnityEngine;

public class Player : MonoBehaviour
{
    // Update is called once per frame
    public float speed = 10f;
    void Update()
    {
        Vector3 input = new Vector3(Input.GetAxisRaw("Horizontal"),0,Input.GetAxisRaw("Vertical"));
        Vector3 direction = input.normalized;
        Vector3 velocity = direction * speed;
        Vector3 amountToMove = velocity * Time.deltaTime;
        transform.Translate(amountToMove);
    }
}

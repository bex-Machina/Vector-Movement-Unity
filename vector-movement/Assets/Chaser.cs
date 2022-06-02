using UnityEngine;

public class Chaser : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform PlayerPosition;
    public float speed = 6;
    // Update is called once per frame
    void Update()
    {
        Vector3 displacementFromPlayer = PlayerPosition.position - transform.position;
        Vector3 direction = displacementFromPlayer.normalized;
        Vector3 velocity = direction * speed;
        Vector3 amountToMove = velocity * Time.deltaTime;
        float distance = displacementFromPlayer.magnitude;
        if (distance > 2f)
        {
            transform.Translate(amountToMove);
        }
        
    }
}

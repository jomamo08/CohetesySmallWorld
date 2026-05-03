using UnityEngine;

public class SmallWorld : MonoBehaviour
{
    public Rigidbody player;   
    public float planetMass;  
    public float G = 9.8f;     

    void FixedUpdate()
    {
        Vector3 direction = transform.position - player.position;

        float distance = direction.magnitude;

        direction.Normalize();

        float force = G * (player.mass * planetMass) / (distance * distance);

        player.AddForce(direction * force);
    }
}
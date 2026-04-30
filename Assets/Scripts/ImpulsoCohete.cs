using UnityEngine;
using UnityEngine.InputSystem;

public class ImpulsoCohete : MonoBehaviour
{
    public float fuerzadespegue = 300f;
    private Rigidbody rb;
    bool launched = false;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
       if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            launched = true;
        }
    }

    void Launch()
    {
        rb.AddForce(Vector3.up * fuerzadespegue, ForceMode.Force);
    }

    void FixedUpdate()
    {
        if (launched == true)
        {
            Launch();
        }
    }
}

/*void OnDrawGizmos()
{
   Gizmos.color = Color.red;
   Gizmos.DrawLine(transform.position, transform.position + direccion * longitudGizmo);
}*/


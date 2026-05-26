using UnityEngine;

public class Character : MonoBehaviour
{
    public Vector3 direction;

    private void Update()
    {
        direction.x = Input.GetAxis("Horizontal");
        direction.z = Input.GetAxis("Vertical");

        transform.position = transform.position + direction; // P = P0 + Vt
    }
}

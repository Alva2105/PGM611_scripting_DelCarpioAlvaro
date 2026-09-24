using UnityEngine;

public class Camara : MonoBehaviour
{
    public Transform target; // El objetivo que la cámara seguirá

    void LateUpdate()
    {
        transform.position = new Vector3(target.position.x, target.position.y, transform.position.z);
    }
}

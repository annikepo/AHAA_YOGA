using UnityEngine;

public class GirarSphere : MonoBehaviour
{
    public float velocidadGiro = 10f; // Velocidad de giro del objeto

    private void Update()
    {
        // Rotamos el objeto sobre su propio eje
        transform.Rotate(Vector3.up, velocidadGiro * Time.deltaTime);
    }
}

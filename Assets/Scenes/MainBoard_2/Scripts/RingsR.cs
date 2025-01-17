using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnilloGiratorio : MonoBehaviour
{
    // Velocidad de rotación del anillo
    public float velocidadRotacionX = 10f;
    public float velocidadRotacionY = 10f;
    public float velocidadRotacionZ = 10f;

    // Corrutina para girar el anillo
    private void Start()
    {
        StartCoroutine(GirarAnillo());
    }

    // Corrutina para girar el anillo
    private IEnumerator GirarAnillo()
    {
        while (true)
        {
            // Rotar el anillo en X
            transform.Rotate(Vector3.right, velocidadRotacionX * Time.deltaTime);

            // Rotar el anillo en Y
            transform.Rotate(Vector3.up, velocidadRotacionY * Time.deltaTime);

            // Rotar el anillo en Z
            transform.Rotate(Vector3.forward, velocidadRotacionZ * Time.deltaTime);

            // Esperar un poco antes de girar de nuevo
            yield return null;
        }
    }
}
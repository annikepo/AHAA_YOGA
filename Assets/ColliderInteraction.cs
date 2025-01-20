using UnityEngine;

public class ColliderInteraction : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("MetaBlock"))
        {
            Debug.Log("Collided with Meta Block");
            // Add your interaction logic here
        }
    }
}

using UnityEngine;

public class VRControllerInteraction : MonoBehaviour
{
    public GameObject Malasana;
    public GameObject Vrksasana;
    public GameObject Utkatasana;
    public GameObject UtthitaTrikonasana;
    public GameObject UtkataKonasana;
    public GameObject BoxBase_collider;

    void Update()
    {
        // Check for interaction with each object
        if (Input.GetButtonDown("Malasana") && Malasana != null)
        {
            // Move to Malasana object
            transform.position = Malasana.transform.position;
        }
        else if (Input.GetButtonDown("Vrksasana") && Vrksasana != null)
        {
            // Move to Vrksasana object
            transform.position = Vrksasana.transform.position;
        }
        else if (Input.GetButtonDown("Utkatasana") && Utkatasana != null)
        {
            // Move to Utkatasana object
            transform.position = Utkatasana.transform.position;
        }
        else if (Input.GetButtonDown("UtthitaTrikonasana") && UtthitaTrikonasana != null)
        {
            // Move to UtthitaTrikonasana object
            transform.position = UtthitaTrikonasana.transform.position;
        }
        else if (Input.GetButtonDown("UtkataKonasana") && UtkataKonasana != null)
        {
            // Move to UtkataKonasana object
            transform.position = UtkataKonasana.transform.position;
        }
        else if (Input.GetButtonDown("BoxBase_collider") && BoxBase_collider != null)
        {
            // Move to BoxBase_collider object
            transform.position = BoxBase_collider.transform.position;
        }
    }
}
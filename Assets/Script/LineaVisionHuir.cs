using UnityEngine;

public class LineaVisionHuir : MonoBehaviour
{
    public float velocidad = 5;
    public Transform objetivo;
    void Start()
    {
        
    }

    void Update()
    {
        Vector3 punto = objetivo.position - transform.position;
        Vector3 vision = transform.position - punto;
        transform.LookAt(vision);
        transform.Translate(Vector3.forward * velocidad * Time.deltaTime);
    }
}

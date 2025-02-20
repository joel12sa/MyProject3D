using UnityEngine;

public class LineVisionPerseguir : MonoBehaviour
{
    public float velocidad = 5;
    public Transform objetivo;
    
    void Start()
    {
        
    }

    void Update()
    {
        transform.LookAt(objetivo);
        transform.Translate(Vector3.forward * velocidad * Time.deltaTime);
    }
}

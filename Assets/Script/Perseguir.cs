using UnityEngine;

public class Perseguir : MonoBehaviour
{
    public float velocidad = 5.0f;
    public Transform objetivo;

    private float x = 0.0f,  y = 0.0f,  z = 0.0f;

    void Start()
    {
        y = transform.position.y;
    }

    void Update()
    {
        x = transform.position.x;
        z = transform.position.z;

        if(objetivo.position.x > x){x += velocidad * Time.deltaTime;}
        if(objetivo.position.x < x){x -= velocidad * Time.deltaTime;}
        if(objetivo.position.z > z){z += velocidad * Time.deltaTime;}
        if(objetivo.position.z < z){z -= velocidad * Time.deltaTime;}
        transform.position = new Vector3(x, y, z);   
    }
}

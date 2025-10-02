using Unity.VisualScripting;
using UnityEngine;

public class BlocParet : MonoBehaviour
{
    private const float LIMIT_Z_NEGATIU = -12f;
    private float vel = 30f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(
            transform.position.x,
            transform.position.y,
            transform.position.z - vel * Time.deltaTime

        );
        //MIREM SI SURT DE LA PANTALLA(CAMARA)
        if (transform.position.z < LIMIT_Z_NEGATIU) { Destroy(gameObject);}
        
        
    }
}

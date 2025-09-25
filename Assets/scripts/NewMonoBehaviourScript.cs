using System;
using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public float vel = 10f;
    private Camera camera;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        camera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        MovimentNau();

    }

    void MovimentNau()
    {
        //control limits pantalla   
        Vector3 limitInferiorEsquerra = camera.ViewportToWorldPoint(new Vector2(0, 0));
        Vector3 limitSuperiorDret = camera.ViewportToWorldPoint(new Vector2(1, 1));

        //moviment nau
        float direccioHoritzontal = Input.GetAxisRaw("Horizontal");
        float direccioVertical = Input.GetAxisRaw("Vertical");
        Vector3 direccio = new Vector3(direccioHoritzontal, direccioVertical, 0).normalized; // (x, y, z)
                                                                                             //Debug.Log("direccioHoritzontal=" + direccio);
        Vector3 nouDesplacament = new Vector3(vel * direccio.x * Time.deltaTime, vel * direccio.y * Time.deltaTime, vel * direccio.z * Time.deltaTime);
        nouDesplacament.x = Math.Clamp(nouDesplacament.x, limitInferiorEsquerra.x, limitSuperiorDret.x);
        nouDesplacament.y = Math.Clamp(nouDesplacament.y, limitInferiorEsquerra.y, limitSuperiorDret.y);
        //Debug.Log("Time.deltaTime =" + Time.deltaTime);
        transform.position += nouDesplacament;
    }
}

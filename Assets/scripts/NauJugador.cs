using System;
using Unity.VisualScripting;
using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public float vel = 10f;
    private Vector3 limitInferiorEsquerra;
    private Vector3 limitSuperiorDret;
    private Camera camera;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        camera = Camera.main;
        float distanciaZCameraNau = Mathf.Abs(transform.position.z - camera.transform.position.z);
        limitInferiorEsquerra = camera.ViewportToWorldPoint(new Vector3(0, 0, distanciaZCameraNau));
        limitSuperiorDret = camera.ViewportToWorldPoint(new Vector3(1, 1, distanciaZCameraNau));
    }

    // Update is called once per frame
    void Update()
    {
        controlLimitsPantalla();
        MovimentNau();

    }

    void MovimentNau()
    {
        //control limits pantalla   


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
    void controlLimitsPantalla()
    {

        Vector3 novaPos = transform.position;

        novaPos.x = Math.Clamp(novaPos.x, limitInferiorEsquerra.x, limitSuperiorDret.x);
        novaPos.y = Math.Clamp(novaPos.y, limitInferiorEsquerra.y, limitSuperiorDret.y);

        transform.position = novaPos;

    }
}

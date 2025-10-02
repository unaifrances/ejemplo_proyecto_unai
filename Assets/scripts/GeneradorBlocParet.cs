using System.Runtime.CompilerServices;
using UnityEngine;

public class GeneradorBlocParet : MonoBehaviour
{
    private const float LIMIT_ESQUERRA = -5;
    private const float LIMIT_DRET = 7f;
    private const float LIMIT_INFERIOR = -1f;
    private const float LIMIT_SUPERIOR = 7f;
    private const float LIMIT_POSTERIOR = 90f;
    public GameObject prefaBlocParet;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //param1: funcio que es cridara repetidament
        //param2: des de que s'obre l'escena, quant tarda a començarse a cridar
        //param3: una vegada ja es crida, cada quant es torna a cridar
        InvokeRepeating("GeneradorBlocParets", 0.5f, 1f);
    }

    // Update is called once per frame
    void Update()
    {



    }
    private void GeneradorBlocParets()
    {
         GameObject paretInferiorEsquerra = Instantiate(prefaBlocParet);
    paretInferiorEsquerra.transform.position = new Vector3(
        LIMIT_ESQUERRA,
        LIMIT_INFERIOR,
        LIMIT_POSTERIOR
    );
    GameObject paretInferiorDreta = Instantiate(prefaBlocParet);
    paretInferiorDreta.transform.transform.position = new Vector3(
        LIMIT_DRET,
        LIMIT_INFERIOR,
        LIMIT_POSTERIOR
    );
    GameObject paretsuperiorDreta = Instantiate(prefaBlocParet);
    paretsuperiorDreta.transform.transform.position = new Vector3(
        LIMIT_DRET,
        LIMIT_SUPERIOR,
        LIMIT_POSTERIOR
    );
        GameObject paretsuperioresquerra = Instantiate(prefaBlocParet);
    paretsuperioresquerra.transform.transform.position = new Vector3(
        LIMIT_ESQUERRA,
        LIMIT_SUPERIOR,
        LIMIT_POSTERIOR
    );
    }

   
}


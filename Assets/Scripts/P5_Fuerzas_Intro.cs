using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P5_Fuerzas_Intro : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] float velocidadFuerza;

    float tiempo_en_pantalla;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();       
        tiempo_en_pantalla = 0; 

        //instantanes
        //rb.AddForce(transform.right * velocidadFuerza, ForceMode.Impulse);  //considera la masa
        //rb.AddForce(transform.right * velocidadFuerza, ForceMode.VelocityChange); //ignora la masa
        
        //continuas
        //rb.AddForce(transform.right * velocidadFuerza, ForceMode.Acceleration); //ignora la masa
        //rb.AddForce(transform.right * velocidadFuerza, ForceMode.Force);  //considera la masa
    }

    private void Update() {
        tiempo_en_pantalla += Time.deltaTime;
        if(tiempo_en_pantalla>1.5f){
            tiempo_en_pantalla = 0;
            gameObject.SetActive(false);
        }
    }

    void FixedUpdate() {                
        rb.AddForce(velocidadFuerza * Time.fixedDeltaTime * transform.forward, ForceMode.Impulse);  //considera la masa
    }
    
}

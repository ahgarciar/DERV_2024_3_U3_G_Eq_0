using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S5_Raycast_Enemigo : MonoBehaviour
{
    [SerializeField] Transform jugador;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direccion = jugador.position - transform.position; //
        direccion = direccion.normalized; //  direccion/magnitude
        RaycastHit hit; //hit almcena informacion de la colision
        //if(Physics.Raycast(transform.position, transform.right*-1,out hit, 10f)){
        if(Physics.Raycast(transform.position, direccion,out hit, 10f)){
            Debug.Log("Colisiona con un objeto");
            //hit.collider.gameObject.ta;
            //Destroy(hit.collider.gameObject)
             Debug.DrawRay(transform.position, direccion * hit.distance, Color.green);
        }else{
            Debug.Log("No colisiona");
            Debug.DrawRay(transform.position, direccion * 10f, Color.red);
        }
    }
}

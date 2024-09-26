using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P4_PosicionEnemigos : MonoBehaviour
{
    [SerializeField] Transform ubi_spawn;
    public GameObject enemigo;

    private void Awake() {        
        enemigo = GameObject.Find("Enemigo");
    }

    private void OnTriggerEnter(Collider other) {
        Debug.Log("" + other.gameObject.tag);
        if(other.gameObject.CompareTag("Player")){
            enemigo.transform.position = ubi_spawn.position;
        }        
    }


}

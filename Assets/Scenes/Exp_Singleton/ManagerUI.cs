using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ManagerUI : MonoBehaviour
{
    public static ManagerUI Instance { get; private set;}

    TextMeshProUGUI []contador;

    float cont_segundos;
    float tiempo_transcurrido;

    private void Awake() {

        if (Instance != null && Instance != this){
            Destroy(gameObject);
        }
        else {            
            Instance = this;
            
            /////////
            contador = GetComponentsInChildren<TextMeshProUGUI>();
            /////////
        }               
        //
    }

    // Start is called before the first frame update
    void Start()
    {
        cont_segundos = 0;
        tiempo_transcurrido = 0;
    }

    // Update is called once per frame
    void Update()
    {
        tiempo_transcurrido += Time.deltaTime;
        if (tiempo_transcurrido>1.0f){
            cont_segundos ++;
            tiempo_transcurrido = 0;
            contador[0].text = cont_segundos.ToString();
        }
    }
}

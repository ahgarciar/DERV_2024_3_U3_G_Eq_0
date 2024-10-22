using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManagerUI_adv : MonoBehaviour
{
    private ManagerUI_adv instance;

    [SerializeField] GameObject usuario;
    TextMeshProUGUI nombre_usuario;
    string usu;
    int id_active_scene;

    private void Awake() {
        
        if (instance != null && instance != this) {

            Destroy(gameObject);

        }else{
            instance = this;
            DontDestroyOnLoad(gameObject);
        }        
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        id_active_scene = SceneManager.GetActiveScene().buildIndex; // 3 , 4 , 5
        //Debug.Log("Escena activa: " + id_active_scene);
       if (id_active_scene!=3)
        { //para todas las demas escenas solo obtengo el nombre de usuario que fue ingresado
            usu = PlayerPrefs.GetString("usu", "");
            Debug.Log("Usuario: " + usu);
        }
    }

    public void cambiarEscena(int index_new){
         if (id_active_scene == 3){
            nombre_usuario = usuario.GetComponent<TextMeshProUGUI>();
            usu = nombre_usuario.text; //almacena el string que ingreso el usuario
            PlayerPrefs.SetString("usu", usu); //almacena en memoria el nombre del usuario
        }
        SceneManager.LoadScene(index_new);
        //
    }
}

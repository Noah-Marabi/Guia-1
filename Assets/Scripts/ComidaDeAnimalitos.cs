using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComidaDeAnimalitos : MonoBehaviour
{
    //Declaramos Variables

   
    public string Animal;
    public int cantidadDeDias;
    float costoAlimento;
    

    // Start is called before the first frame update
    void Start()
    {
      //Validacion de Datos

        if ( cantidadDeDias < 3)
        {
            Debug.Log("Se debe de ingresar una catidad de dias mayor a 3");
            return;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

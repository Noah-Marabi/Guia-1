using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeclaracionDeVariables : MonoBehaviour
{
    int edadUsuario;
    float sueldoUsuario;
    string domicilio;
    bool estaAprobado;

    // Start is called before the first frame update
    void Start()
    {
        //Primeras variables
        edadUsuario = 16;
        sueldoUsuario = 10000.00f;
        domicilio = "Hipolito Yrigoyen 650";
        estaAprobado = false;

        // Las muestro en consola
        Debug.Log(edadUsuario);
        Debug.Log(sueldoUsuario);
        Debug.Log(domicilio);
        Debug.Log(estaAprobado);
    }

    // Update is called once per frame
    void Update()
    {

    }
}

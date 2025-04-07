using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConversionDeMonedas : MonoBehaviour
{
    //Declaramos variables

    public float montoAConvertir;
    public string codigoMoneda;

    float montoConvertido;
    float montoMinimoAConvertir = 1000;
    float cotizacionMonedaElegida;
    float cotizacionDolar = 1297.21f;
    float cotizacionEuro = 1621.3f;
    float cotizacionReal = 183.0f;

    // Start is called before the first frame update
    void Start()
    {
        //validacion de datos

        if (montoAConvertir < montoMinimoAConvertir)
        {
            Debug.Log("El monto minimo es $1000");
            return;
        }

        if (codigoMoneda == "E")
        {
            cotizacionMonedaElegida = cotizacionEuro;

        }else if (codigoMoneda == "D")
        {
            cotizacionMonedaElegida = cotizacionDolar;

        }else if (codigoMoneda == "R")
        {

            cotizacionMonedaElegida = cotizacionReal;

        }else
        {
            Debug.Log("Opcion de moneda extranjera no valida");
            return;
        }

        //Procesamiento de datos

        montoConvertido = montoAConvertir / cotizacionMonedaElegida;

        //salida

        Debug.Log("La conversion de ese monto de pesos equivale a " + montoConvertido);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

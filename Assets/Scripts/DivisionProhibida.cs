using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DivisionProhibida : MonoBehaviour
{
    public int Num1;
    public int Num2;
    float resultado;

    // Start is called before the first frame update
    void Start()
    {
        if(Num2 == 0)
        {
            //instrucciones por true
            Debug.Log("No se puede dividir por cero");
        }else
        {
            //instrucciones por false
            resultado = Num1 / (Num2 * 1.0f);
            Debug.Log(Num1 + "/" + Num2 + " = " + resultado);
        }
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeclaracionDelUsuario : MonoBehaviour
{
    public string nombreUsuario;
    public int edadUsuario;
    public float alturaUsuario;
    public bool esDonante;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Mi nombre es"+ nombreUsuario + ", tengo " + edadUsuario + ", mido " + alturaUsuario + " y es " + esDonante + " que soy donante de organos.");
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}

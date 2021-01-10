using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour {
    
    [Header("Properties")]
    public float workToGenerate;
    public float workPerTick;

    [Header("Internals")]
    public bool isActive;
    public float work;
    public float energy;

    private void Update() {
        if ( Input.GetButtonDown("Fire1") ) {
            isActive = !isActive;
        }
    }

    private void FixedUpdate() {
        
        //if machine is off, don't modify anthing
        if ( !isActive )
            return;

        if ( work == workToGenerate ) {
            Generate();
            work = 0;
        } else {
            work += workPerTick;
        }

    }

    public void Generate() {
        Debug.Log("ia deaici ca nai servici");
    }

}

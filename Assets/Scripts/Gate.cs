using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Gate : MonoBehaviour
{
    [SerializeField] private bool gateIsActive = false;
    [SerializeField] private UnityEvent GateOpened;
    [SerializeField] private UnityEvent PlayerEnteredGate;

    public void Awake(){
      if(gateIsActive) GateOpened.Invoke();
    }

    public void OpenGate(){
      if(!gateIsActive){
        gateIsActive = true;
        GateOpened.Invoke();
      }
    }

    public void OnCollisionEnter(Collision col){
      if(col.gameObject.tag == "Player" && gateIsActive)PlayerEnteredGate.Invoke();
    }
}

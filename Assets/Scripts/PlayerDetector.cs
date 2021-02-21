using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerDetector : MonoBehaviour
{
  [SerializeField] private UnityEvent PlayerDetected;

  public void OnTriggerEnter(Collider col){
    if(col.gameObject.tag == "Player") PlayerDetected.Invoke();
    Debug.Log("Sensor touched something with tag: " + col.gameObject.tag);
  }
}

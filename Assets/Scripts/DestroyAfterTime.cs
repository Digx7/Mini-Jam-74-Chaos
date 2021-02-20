using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAfterTime : MonoBehaviour
{
    [SerializeField] private GameObject objectToDestroy;
    [SerializeField] private float timeToDestroy;
    [SerializeField] bool destroyOnAwake;

    public void Awake(){
      if(objectToDestroy == null) objectToDestroy = this.gameObject;
      if(destroyOnAwake) _Destroy();
    }

    public void _Destroy(){
      Destroy(objectToDestroy,timeToDestroy);
    }
}

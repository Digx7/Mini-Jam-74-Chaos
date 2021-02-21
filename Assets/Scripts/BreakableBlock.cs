using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BreakableBlock : MonoBehaviour
{
  [SerializeField] private int currentHealth;
  [SerializeField] private int maxHealth;
  [SerializeField] private GameObject rockHitParticals;
  [SerializeField] private GameObject rockDestroyedParticals;
  [Space]
  [SerializeField] private UnityEvent rockHit;
  [SerializeField] private UnityEvent rockDestoryed;

  private void wasHit(){
    rockHit.Invoke();
    Instantiate(rockHitParticals, this.gameObject.transform.position, Quaternion.identity);
    Debug.Log("Rock was Hit");
    currentHealth--;
    if(checkIsDead())isDead();
  }

  private void isDead(){
    Instantiate(rockDestroyedParticals, this.gameObject.transform.position, Quaternion.identity);
    rockDestoryed.Invoke();
  }

  private bool checkIsDead(){
    if(currentHealth == 0 || currentHealth < 0) return true;
    else return false;
  }

  public void OnCollisionEnter(Collision col){
    if(col.gameObject.tag == "Laser") wasHit();
    Debug.Log("Rock touched something with tag: " + col.gameObject.tag);
  }
}

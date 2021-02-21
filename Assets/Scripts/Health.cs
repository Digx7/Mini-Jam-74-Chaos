using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Health : MonoBehaviour
{
    [SerializeField] private GameManager gameManager;
    [SerializeField] private int currentHealth;
    [SerializeField] private int maxHealth;
    [SerializeField] private UnityEvent playerDied;
    [SerializeField] private UnityEvent playerDamaged;

    public void Awake(){
      if(gameManager == null) gameManager = FindObjectOfType<GameManager>();
    }

    public void wasHit(){
      playerDamaged.Invoke();
      Debug.Log("Player was Hit");
      currentHealth--;
      if(checkIsDead())isDead();
    }

    public void resetHealth(){
      currentHealth = maxHealth;
    }

    private bool checkIsDead(){
      if(currentHealth == 0 || currentHealth < 0) return true;
      else return false;
    }

    private void isDead(){
      playerDied.Invoke();
      gameManager.playerDied();
    }

    public void OnTriggerEnter(Collider col){
      if(col.gameObject.tag == "Enemy") wasHit();
      Debug.Log("Player touched something with tag: " + col.gameObject.tag);
    }

    public void OnCollisionEnter(Collision col){
      if(col.gameObject.tag == "Enemy") wasHit();
      Debug.Log("Player touched something with tag: " + col.gameObject.tag);
    }
}

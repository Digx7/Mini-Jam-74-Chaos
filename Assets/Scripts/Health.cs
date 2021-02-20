using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Health : MonoBehaviour
{
    [SerializeField] private int currentHealth;
    [SerializeField] private int maxHealth;
    [SerializeField] private UnityEvent playerDied;

    public void wasHit(){
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
    }
}

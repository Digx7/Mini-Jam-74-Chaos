using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Enemy : MonoBehaviour
{
    [SerializeField] private bool noticedPlayer = false;
    [SerializeField] private float movementSpeed;
    [SerializeField] private GameObject player;
    [Space]
    [SerializeField] private int currentHealth;
    [SerializeField] private int maxHealth;
    [SerializeField] private UnityEvent enemyDamaged;
    [SerializeField] private UnityEvent enemyDied;
    [Space]
    [SerializeField] private GameObject enemyHurtSparks;
    [SerializeField] private GameObject enemyDeathSparks;

    private Rigidbody rb;

    public void Awake(){
      if(player == null)player = FindObjectOfType<Ship>().gameObject;
      rb = this.gameObject.GetComponent<Rigidbody>();
    }

    public void PlayerSpotted(){
      noticedPlayer = true;
    }

    public void FixedUpdate(){
      if(noticedPlayer){
        FacePlayer();
        Move();
      }
    }

    private void FacePlayer(){
      Quaternion targetRotation = Quaternion.LookRotation (player.transform.position - transform.position);
      rb.MoveRotation(targetRotation);
    }

    private void Move(){
      rb.AddForce(transform.forward * movementSpeed * Time.deltaTime);
    }

    private void wasHit(){
      enemyDamaged.Invoke();
      Instantiate(enemyHurtSparks, this.gameObject.transform.position, Quaternion.identity);
      Debug.Log("Enemy was Hit");
      currentHealth--;
      if(checkIsDead())isDead();
    }

    private void isDead(){
      Instantiate(enemyDeathSparks, this.gameObject.transform.position, Quaternion.identity);
      enemyDied.Invoke();
    }

    private bool checkIsDead(){
      if(currentHealth == 0 || currentHealth < 0) return true;
      else return false;
    }

    /*public void OnTriggerEnter(Collider col){
      if(col.gameObject.tag == "DubstepLaser") wasHit();
      Debug.Log("Enemy touched something with tag: " + col.gameObject.tag);
    }*/

    public void OnCollisionEnter(Collision col){
      if(col.gameObject.tag == "DubstepLaser") wasHit();
      Debug.Log("Enemy touched something with tag: " + col.gameObject.tag);
    }


}

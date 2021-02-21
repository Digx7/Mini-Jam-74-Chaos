using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gem : MonoBehaviour
{
    [SerializeField] private GameManager gameManager;
    [SerializeField] private GameObject collectedParticles;

    public void Awake(){
      if(gameManager == null) gameManager = FindObjectOfType<GameManager>();
    }

    public void OnTriggerEnter(Collider col){
      if(col.gameObject.tag == "PlayerGrab") gemPickedUp();
    }

    public void OnColliderEnter(Collision col){
      if(col.gameObject.tag == "PlayerGrab") gemPickedUp();
    }

    private void gemPickedUp(){
      gameManager.gemCollected();
      Instantiate(collectedParticles, this.transform.position, Quaternion.identity);
      Destroy(this.gameObject);
    }
}

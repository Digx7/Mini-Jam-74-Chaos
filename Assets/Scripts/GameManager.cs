using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{
    public bool isPlayerDead = false;
    [SerializeField] private int currentGemCount;
    [SerializeField] private int maxGemCount;
    [SerializeField] private UnityEvent playerCollectedAllGems;

    public void gemCollected(){
      currentGemCount++;
      if(hasCollectedAllGems()) collectedAllGems();
    }

    public void playerDied(){
      isPlayerDead = true;
    }

    private bool hasCollectedAllGems(){
      if(currentGemCount == maxGemCount || currentGemCount > maxGemCount)return true;
      else return false;
    }

    private void collectedAllGems(){
      playerCollectedAllGems.Invoke();
    }
}

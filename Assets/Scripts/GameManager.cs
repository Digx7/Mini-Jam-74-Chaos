using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{
    public bool isPlayerDead = false;
    [SerializeField] private int currentGemCount;
    [SerializeField] private int maxGemCount;
    [Space]
    [SerializeField] private string nameOfNextLevel;
    [Space]
    [SerializeField] private UnityEvent playerCollectedAllGems;
    [SerializeField] private UnityEvent LevelFailed;
    [SerializeField] private UnityEvent LevelCompleted;

    public void gemCollected(){
      currentGemCount++;
      if(hasCollectedAllGems()) collectedAllGems();
    }

    public void playerDied(){
      isPlayerDead = true;
      LevelFailed.Invoke();
    }

    public void playerReachedGate(){
      LevelCompleted.Invoke();
    }

    public void LoadNextLevel(){
      SceneManager.LoadSceneAsync(nameOfNextLevel);
    }

    public void ReloadLevel(){
      SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().name);
    }

    private bool hasCollectedAllGems(){
      if(currentGemCount == maxGemCount || currentGemCount > maxGemCount)return true;
      else return false;
    }

    private void collectedAllGems(){
      playerCollectedAllGems.Invoke();
    }
}

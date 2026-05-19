using System;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private bool isGameOver = false;
    //private float _surviveTime = 0;
    
    // public float SurviveTime => _surviveTime;
    //public float SurviveTime { get => _surviveTime;  set => _surviveTime = value; }

    private void Start()
    { 
        
        isGameOver = false;
    }

    public void GameOver()
    {
        
    }
}

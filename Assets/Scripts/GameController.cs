using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public static GameController Instance;
    public GameObject gameOverPanel;
    public TextMeshProUGUI scoreTextComponent;
    public int score = 0;
    public bool gameOver = false;                //Is the game over?
    public float scrollSpeed = -1.5f;
    public BirdInput birdInput;
    public bool hasStarted = false;
    public ColumnPool columnPool;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }

        if (Instance != this)
        {
            Destroy(Instance.gameObject);
        }
        
        Instance.birdInput = new BirdInput();
        Instance.birdInput.Enable();
    }

    private void Start()
    {
        Instance.birdInput.Bird.Flap.performed += OnFlapPerformed;
    }

    private void OnFlapPerformed(InputAction.CallbackContext ctx)
    {
        if (gameOver){
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            Instance.birdInput.Disable();
            Instance.birdInput.Dispose();
        }
    }

    public void BirdScore()
    {
        if (gameOver) return;
        score++;
        scoreTextComponent.text = $"Score: {score}";
    }
    
    public void BirdDied()
    {
        gameOverPanel.SetActive (true);
        gameOver = true;
    }
}

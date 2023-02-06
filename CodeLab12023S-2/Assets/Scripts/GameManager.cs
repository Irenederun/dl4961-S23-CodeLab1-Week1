using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public int score = 0;
    private int level = 0;
    private int targetScore = 4;

    private void Awake()
    {
        if (Instance == null)
            //if no other instance of this game object in scene
        {
            DontDestroyOnLoad(gameObject);
            //don't destroy
            Instance = this;
            //set instance to this one
        }
        else
            //if there is
        {
            Destroy(gameObject);
            //destroy self
        }
    }

    
    // Update is called once per frame
    void Update()
    {
        if (score == targetScore)
            //if reaches target score
        {
            score = 0;
            //reset score
            level++;
            //increase level
            SceneManager.LoadScene(level);
            //load level
        }
    }
}

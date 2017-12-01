﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    private Animator animator;
    public string firstLevel = "puzzle-1";

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Use this for initialization
    void onAnimationCompleted_fade()
    {
        animator.SetTrigger("doMove");
    }

    // Update is called once per frame
    void onAnimationCompleted_move()
    {
        animator.SetTrigger("doSplit");
    }

    void onAnimationCompleted_split()
    {
        animator.SetTrigger("doRevealText");
    }

    public void onClick_startGame() {
        SceneManager.LoadScene(firstLevel);
    }
}

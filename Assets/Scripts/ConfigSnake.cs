using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SnakeConfig", menuName = "Snake/Config", order = 0)]
public class ConfigSnake : ScriptableObject
{
    [Space(5)]
    [Header("Snake Config:")]
    [Tooltip("Set head speed.")]
    public float headSpeed = 1;
    [Tooltip("Set the head rotation speed.")]
    public float headRotationSpeed = 2;
    [Tooltip("Pick the corner of the head behind the cursor.")]
    public float headAngle = 0;
    [Tooltip("Set trail speed.")]
    public float trailSpeed = 1;
    [Tooltip("Set the trail rotation speed.")]
    public float trailRotationSpeed = 5;
    [Tooltip("Pick the corner of the tail behind the cursor.")]
    public float trailAngle = 0;
    [Tooltip("Death by collision.")]
    public bool dead;
    [Space(5)]
    [Header("UI Config:")]
    public int score;
    [Header("Set text start")]
    public string[] texts;
    [Space(5)]
    [Header("Apple Config:")]
    public float retunApple = 5;

    public void RestartLevel() => UnityEngine.SceneManagement.SceneManager.LoadScene(0);

}

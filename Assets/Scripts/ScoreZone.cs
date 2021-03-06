﻿using UnityEngine;
using UnityEngine.Events;

public class ScoreZone : MonoBehaviour
{
    public UnityEvent OnScoreZoneEnter;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            OnScoreZoneEnter?.Invoke();
        }
    }
}

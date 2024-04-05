using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEnding : MonoBehaviour
{
    [SerializeField] float fadeDuraction = 1f;

    [SerializeField] float displayImageDuration = 1f;

    [SerializeField] GameObject player;

    [SerializeField] CanvasGroup exitBackgroundImageCanvasGroup;


    float m_Timer;

    bool m_IsPlayerExit;

    private void Update()
    {
        if (m_IsPlayerExit)
        {
            EndLevel();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)
        {
            m_IsPlayerExit = true;
        }
    }

    void EndLevel()
    {
        m_Timer += Time.deltaTime;

        exitBackgroundImageCanvasGroup.alpha = m_Timer / fadeDuraction;

        if (m_Timer > fadeDuraction + displayImageDuration)
        {
            Application.Quit();
        }
    }
}

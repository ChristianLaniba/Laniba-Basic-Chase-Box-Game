using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

#if UNITY_EDITOR
using UnityEditor;
#endif


public class GameManager : MonoBehaviour
{
    public float timeLeft = 10f;
    public TMP_Text timerText;
    public GameObject winScreen;
    public GameObject loseScreen;

    bool gameEnded = false;

    void Update()
    {
        if (gameEnded) return;

        timeLeft -= Time.deltaTime;
        timerText.text = "0:" + Mathf.Ceil(timeLeft);

        if (timeLeft <= 0)
        {
            Win();
        }
    }

    public void Lose()
    {
        if (gameEnded) return;
        gameEnded = true;
        loseScreen.SetActive(true);
        Time.timeScale = 0f;

        #if UNITY_EDITOR
        EditorApplication.isPlaying = false;
        #endif
    }

    public void Win()
    {
        if (gameEnded) return;
        gameEnded = true;
        winScreen.SetActive(true);
        Time.timeScale = 0f;

        #if UNITY_EDITOR
        EditorApplication.isPlaying = false;
        #endif
    }
}

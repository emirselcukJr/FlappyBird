using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class GameManager : MonoBehaviour
{
    
    int skor;

    [SerializeField]
    Text skorYazisi;

    public void SkorUpdate()
    {
        skor++;
        skorYazisi.text = skor.ToString();

    }

    public void RestartGame()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }
}

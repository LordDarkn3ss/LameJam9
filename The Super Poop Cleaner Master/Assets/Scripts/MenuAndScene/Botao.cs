using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Botao : MonoBehaviour
{
    
    public void Resume()
    {
        Time.timeScale = 1;
        InterfaceInGame.paused = false;
    }
    public void TryAgain(string sceneName)
    {
        Time.timeScale = 1;
        InterfaceInGame.paused = false;
        ShitBarBehaviourScript.die = false;
        SceneManager.LoadScene(sceneName);
    }

    public void StartGameScene(string sceneName)
    {
        Time.timeScale = 1;
        InterfaceInGame.paused = false;
        SceneManager.LoadScene(sceneName);
    }
    public void MuteMusic()
    {

    }
    public void MuteSoundEffects()
    {

    }
    public void ChangeIdioma()
    {

    }
    public void endGame()
    {
        Application.Quit();
    }
}

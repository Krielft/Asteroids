using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool gameIsPaused = false;

    public GameObject pauseMenuUI;

    public GameObject settingsWindow;
    public GameObject audioBoard;
    public GameObject graphicBoard;
    public GameObject controlsBoard;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(gameIsPaused)
            {
                Resume();
            }
            else
            {
                Paused();
            }
        }
    }

    void Paused()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0;
        gameIsPaused = true;

    }
    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1;
        gameIsPaused = false;
    }

    public void LoadMainMenu()
    {
        Resume();
        SceneManager.LoadScene("HUD");
    }

    public void Options()
    {
        settingsWindow.SetActive(true);
        controlsBoard.SetActive(true);
    }

    public void CloseSettingsWindow()
    {
        settingsWindow.SetActive(false);

        audioBoard.SetActive(false);
        graphicBoard.SetActive(false);
    }

    public void AudioBoard()
    {
        settingsWindow.SetActive(true);
        audioBoard.SetActive(true);
        graphicBoard.SetActive(false);
        controlsBoard.SetActive(false);
    }
    public void GraphicBoard()
    {
        settingsWindow.SetActive(true);
        audioBoard.SetActive(false);
        graphicBoard.SetActive(true);
        controlsBoard.SetActive(false);
    }
    public void ControlsBoard()
    {
        settingsWindow.SetActive(true);
        audioBoard.SetActive(false);
        graphicBoard.SetActive(false);
        controlsBoard.SetActive(true);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}

using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public string levelToLoad;

    public GameObject loadAGame;
    public GameObject settingsWindow;
    public GameObject controlsBoard;
    public GameObject audioBoard;
    public GameObject graphicBoard;
    public GameObject creditsWindow;
    public GameObject CreditsButton;
    public GameObject ExtraPanel;
    public GameObject QuitGameButton;

    public void Play()
    {
        SceneManager.LoadScene("Asteroids");
    }
    public void LoadAGame()
    {
        loadAGame.SetActive(true);
    }

    public void CloseLoadAGame()
    {
        loadAGame.SetActive(false);
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

        CreditsButton.SetActive(true);
        QuitGameButton.SetActive(true);
    }
    public void ControlsBoard()
    {
        settingsWindow.SetActive(true);
        audioBoard.SetActive(false);
        graphicBoard.SetActive(false);
        controlsBoard.SetActive(true);
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
    public void Extra()
    {
        ExtraPanel.SetActive(true);
        CreditsButton.SetActive(true);
        QuitGameButton.SetActive(false);
    }

    public void CloseExtra()
    {
        ExtraPanel.SetActive(false);
        CreditsButton.SetActive(false);
        QuitGameButton.SetActive(true);
    }

    public void Credits()
    {
        creditsWindow.SetActive(true);
        CreditsButton.SetActive(false);
        QuitGameButton.SetActive(false);
    }

    public void CloseCreditsWindow()
    {
        creditsWindow.SetActive(false);
        CreditsButton.SetActive(true);
        QuitGameButton.SetActive(true);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}

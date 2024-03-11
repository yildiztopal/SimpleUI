using UnityEngine;

public class MainMenu : MonoBehaviour
{
    /* Start Game panel will have an input box to enter your name
     * Continue game panel will have scroll bar with buttons to select save to continue from
     * also implement all the music stuff and put some loyalty free retro music
     */

    public GameObject mainMenuPanel;
    public GameObject settingsPanel;

    private void Start()
    {
        mainMenuPanel.SetActive(true);
        settingsPanel.SetActive(false);
    }

    public void StartGame()
    {

    }

    public void ContinueGame()
    {
        
    }

    public void OpenSettings()
    {
        mainMenuPanel.SetActive(false);
        settingsPanel.SetActive(true);
    }

    public void ReturnToMainMenu()
    {
        mainMenuPanel.SetActive(true);
        settingsPanel.SetActive(false);
    }

    public void ToggleSound()
    {

    }

    public void ToggleMusic()
    {

    }
}

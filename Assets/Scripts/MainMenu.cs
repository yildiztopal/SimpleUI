using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class MainMenu : MonoBehaviour
{
    /* Start Game panel will have an input box to enter your name
     * Continue game panel will have scroll bar with buttons to select save to continue from
     * also implement all the music stuff and put some loyalty free retro music
     */

    public GameObject mainMenuPanel;
    public GameObject settingsPanel;
    public GameObject startGamePanel;
    public GameObject continuePanel;

    public TMP_InputField nameInputField;
    public TMP_Dropdown saveDropdown;

    private void Start()
    {
        mainMenuPanel.SetActive(true);
        settingsPanel.SetActive(false);
        startGamePanel.SetActive(false);
        continuePanel.SetActive(false);
    }

    public void StartGame()
    {
        mainMenuPanel.SetActive(false);
        startGamePanel.SetActive(true);
    }

    public void ContinueGame()
    {
        mainMenuPanel.SetActive(false);
        continuePanel.SetActive(true);
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
        startGamePanel.SetActive(false);
        continuePanel.SetActive(false);
    }

    public void OpenScene()
    {
        SceneManager.LoadScene(1);
    }

    public void EnterName()
    {
        if (nameInputField.text != null)
            PlayerPrefs.SetString("name", nameInputField.text);
    }

    public void ChooseSave()
    {
        PlayerPrefs.SetString("save", saveDropdown.options[saveDropdown.value].text);
    }

    public void ToggleSound()
    {
        Debug.Log("Toggle sound");
    }

    public void ToggleMusic()
    {
        Debug.Log("Toggle music");
    }
}

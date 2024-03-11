using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameLevel : MonoBehaviour
{
    public GameObject nameOrSaveText;
    string playerSave = "";
    string playerName = "";

    public void UpdateLevelInfo()
    {
        if(PlayerPrefs.HasKey("name"))
        {
            playerName = PlayerPrefs.GetString("name");
            nameOrSaveText.GetComponent<TextMeshPro>().text = "Name: " + playerName;
        }
            
        if (PlayerPrefs.HasKey("save"))
        {
            playerSave = PlayerPrefs.GetString("save");
            nameOrSaveText.GetComponent<TextMeshPro>().text = "Save: " + playerSave;
        }

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public InputField usernameInput;
    public static string username;
    public TextMeshProUGUI textDisplay;

    void Start(){
        if (username != null){
            usernameInput.text = username;
        }
    }

    public void PlayGame(){

    }

    public void Quit(){
        Debug.Log("Quit");
        Application.Quit();
    }

    public void SaveUsername(string newName){
        username = newName;
    }

    void displayUsername(){
        textDisplay.text = username;
    }
}

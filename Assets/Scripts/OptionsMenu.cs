using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionsMenu : MonoBehaviour
{
    public int frameRate = 60; 

    public GameObject startingUI;
    public GameObject optionsUI;

    public Dropdown resolutionDropdown;
    // Start is called before the first frame update

    public void OpenStartingScreen()
    {
        startingUI.SetActive(true);

        optionsUI.SetActive(false);
    }
    public void OpenOptions() 
    {
        startingUI.SetActive(false);

        optionsUI.SetActive(true);
        //optionsUI[1].SetActive(false);
        //optionsUI[2].SetActive(false);
    }

    public void ResolutionChange()
    {
        if (resolutionDropdown.value == 0) {Screen.SetResolution(640, 360, FullScreenMode.FullScreenWindow, frameRate); }
        else if (resolutionDropdown.value == 1) {Screen.SetResolution(854, 480, FullScreenMode.FullScreenWindow, frameRate); }
        else if (resolutionDropdown.value == 2) {Screen.SetResolution(1280, 720, FullScreenMode.FullScreenWindow, frameRate); }
        else if (resolutionDropdown.value == 3) {Screen.SetResolution(1920, 1080, FullScreenMode.FullScreenWindow, frameRate); }
        else if (resolutionDropdown.value == 4) {Screen.SetResolution(2560, 1440, FullScreenMode.FullScreenWindow, frameRate); }
        else if (resolutionDropdown.value == 5) {Screen.SetResolution(3840, 2160, FullScreenMode.FullScreenWindow, frameRate); }
        else {Screen.SetResolution(640, 360, FullScreenMode.FullScreenWindow, frameRate);}
    }

}



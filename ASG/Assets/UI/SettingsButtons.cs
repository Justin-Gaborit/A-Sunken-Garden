using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class SettingsButtons : MonoBehaviour
{
    public bool subtitles;
    public bool fullscreen;
    public bool windowed;
    public GameObject CheckMark;
    public GameObject windowedCheck;
    public GameObject fullscreenCheck;
    public GameObject windowedButton;
    public GameObject fullscreenButton;
    public bool launched = false;
    private bool check = false;
    private bool audioCheck = false;


    //sound buttons

    public bool sound;
    public GameObject soundButton1;
    public GameObject soundButton2;
    public GameObject soundButton3;
    public GameObject soundButton4;
    public GameObject soundButton5;
    public GameObject soundButton6;
    public GameObject soundButton7;
    public GameObject soundButton8;
    public GameObject soundButton9;
    public GameObject soundButton10;

    //music buttons

    public bool music;
    public GameObject musicButton1;
    public GameObject musicButton2;
    public GameObject musicButton3;
    public GameObject musicButton4;
    public GameObject musicButton5;
    public GameObject musicButton6;
    public GameObject musicButton7;
    public GameObject musicButton8;
    public GameObject musicButton9;
    public GameObject musicButton10;

    // Sets values at start

    void Start()
    {
        if (launched == false)
        {
            launched = true;
            fullscreen = true;
            subtitles = false;
            windowed = false;
            sound = true;
            music = true;
        }
    }

    //function to check which button is pressed and the appropriate game object for togglable UI to be enabled/disabled
    public void active()
    {
        if (gameObject.tag == "subtitles" && subtitles == false)
        {
            subtitles = true;
            CheckMark.SetActive(true);
        }
        else if (gameObject.tag == "subtitles" && subtitles == true)
        {
            subtitles = false;
            CheckMark.SetActive(false);
        }

        if (gameObject.tag == "fullscreen" && fullscreen == false && check == false)
        {
            fullscreen = true;
            fullscreenCheck.SetActive(true);
            windowed = false;
            windowedCheck.SetActive(false);
            check = true;
            windowedButton.GetComponent<SettingsButtons>().windowed = false;
            windowedButton.GetComponent<SettingsButtons>().fullscreen = true;
        }
        else if (gameObject.tag == "fullscreen" && fullscreen == true && check == false)
        {
            fullscreen = false;
            fullscreenCheck.SetActive(false);
            windowed = true;
            windowedCheck.SetActive(true);
            check = true;
            windowedButton.GetComponent<SettingsButtons>().windowed = true;
            windowedButton.GetComponent<SettingsButtons>().fullscreen = false;
        }

        if (gameObject.tag == "windowed" && windowed == false && check == false)
        {
            windowed = true;
            windowedCheck.SetActive(true);
            fullscreen = false;
            fullscreenCheck.SetActive(false);
            check = true;
            fullscreenButton.GetComponent<SettingsButtons>().fullscreen = false;
            fullscreenButton.GetComponent<SettingsButtons>().windowed = true;
        }

        else if (gameObject.tag == "windowed" && windowed == true && check == false)
        {
            windowed = false;
            windowedCheck.SetActive(false);
            fullscreen = true;
            fullscreenCheck.SetActive(true);
            check = true;
            fullscreenButton.GetComponent<SettingsButtons>().fullscreen = true;
            fullscreenButton.GetComponent<SettingsButtons>().windowed = false;
        }
            check = false;


        //Audio Buttons Functionality

        //sound button 1

        if (gameObject.tag == "sound" && gameObject == soundButton1 && sound == false && audioCheck == false)
        {
            sound = true;
            CheckMark.SetActive(true);
            audioCheck = true;
        }

        else if (gameObject.tag == "sound" && gameObject == soundButton1 && sound == true && audioCheck == false)
        {
            sound = false;
            CheckMark.SetActive(false);
            soundButton2.GetComponent<SettingsButtons>().CheckMark.SetActive(false);
            soundButton3.GetComponent<SettingsButtons>().CheckMark.SetActive(false);
            soundButton4.GetComponent<SettingsButtons>().CheckMark.SetActive(false);
            soundButton5.GetComponent<SettingsButtons>().CheckMark.SetActive(false);
            soundButton6.GetComponent<SettingsButtons>().CheckMark.SetActive(false);
            soundButton7.GetComponent<SettingsButtons>().CheckMark.SetActive(false);
            soundButton8.GetComponent<SettingsButtons>().CheckMark.SetActive(false);
            soundButton9.GetComponent<SettingsButtons>().CheckMark.SetActive(false);
            soundButton10.GetComponent<SettingsButtons>().CheckMark.SetActive(false);
            soundButton2.GetComponent<SettingsButtons>().sound = false;
            soundButton3.GetComponent<SettingsButtons>().sound = false;
            soundButton4.GetComponent<SettingsButtons>().sound = false;
            soundButton5.GetComponent<SettingsButtons>().sound = false;
            soundButton6.GetComponent<SettingsButtons>().sound = false;
            soundButton7.GetComponent<SettingsButtons>().sound = false;
            soundButton8.GetComponent<SettingsButtons>().sound = false;
            soundButton9.GetComponent<SettingsButtons>().sound = false;
            soundButton10.GetComponent<SettingsButtons>().sound = false;
            audioCheck = true;
        }

        //sound button 2

        if (gameObject.tag == "sound" && gameObject == soundButton2 && sound == false && audioCheck == false)
        {
            sound = true;
            CheckMark.SetActive(true);
            soundButton1.GetComponent<SettingsButtons>().CheckMark.SetActive(true);
            soundButton1.GetComponent<SettingsButtons>().sound = true;
            audioCheck = true;
        }

        else if (gameObject.tag == "sound" && gameObject == soundButton2 && sound == true && audioCheck == false)
        {
            sound = false;
            CheckMark.SetActive(false);
            soundButton3.GetComponent<SettingsButtons>().CheckMark.SetActive(false);
            soundButton4.GetComponent<SettingsButtons>().CheckMark.SetActive(false);
            soundButton5.GetComponent<SettingsButtons>().CheckMark.SetActive(false);
            soundButton6.GetComponent<SettingsButtons>().CheckMark.SetActive(false);
            soundButton7.GetComponent<SettingsButtons>().CheckMark.SetActive(false);
            soundButton8.GetComponent<SettingsButtons>().CheckMark.SetActive(false);
            soundButton9.GetComponent<SettingsButtons>().CheckMark.SetActive(false);
            soundButton10.GetComponent<SettingsButtons>().CheckMark.SetActive(false);
            soundButton3.GetComponent<SettingsButtons>().sound = false;
            soundButton4.GetComponent<SettingsButtons>().sound = false;
            soundButton5.GetComponent<SettingsButtons>().sound = false;
            soundButton6.GetComponent<SettingsButtons>().sound = false;
            soundButton7.GetComponent<SettingsButtons>().sound = false;
            soundButton8.GetComponent<SettingsButtons>().sound = false;
            soundButton9.GetComponent<SettingsButtons>().sound = false;
            soundButton10.GetComponent<SettingsButtons>().sound = false;
            audioCheck = true;
        }

        //sound button 3

        if (gameObject.tag == "sound" && gameObject == soundButton3 && sound == false && audioCheck == false)
        {
            sound = true;
            CheckMark.SetActive(true);
            soundButton1.GetComponent<SettingsButtons>().CheckMark.SetActive(true);
            soundButton2.GetComponent<SettingsButtons>().CheckMark.SetActive(true);
            soundButton1.GetComponent<SettingsButtons>().sound = true;
            soundButton2.GetComponent<SettingsButtons>().sound = true;
            audioCheck = true;
        }

        else if (gameObject.tag == "sound" && gameObject == soundButton3 && sound == true && audioCheck == false)
        {
            sound = false;
            CheckMark.SetActive(false);
            soundButton4.GetComponent<SettingsButtons>().CheckMark.SetActive(false);
            soundButton5.GetComponent<SettingsButtons>().CheckMark.SetActive(false);
            soundButton6.GetComponent<SettingsButtons>().CheckMark.SetActive(false);
            soundButton7.GetComponent<SettingsButtons>().CheckMark.SetActive(false);
            soundButton8.GetComponent<SettingsButtons>().CheckMark.SetActive(false);
            soundButton9.GetComponent<SettingsButtons>().CheckMark.SetActive(false);
            soundButton10.GetComponent<SettingsButtons>().CheckMark.SetActive(false);
            soundButton4.GetComponent<SettingsButtons>().sound = false;
            soundButton5.GetComponent<SettingsButtons>().sound = false;
            soundButton6.GetComponent<SettingsButtons>().sound = false;
            soundButton7.GetComponent<SettingsButtons>().sound = false;
            soundButton8.GetComponent<SettingsButtons>().sound = false;
            soundButton9.GetComponent<SettingsButtons>().sound = false;
            soundButton10.GetComponent<SettingsButtons>().sound = false;
            audioCheck = true;
        }

        //sound button 4

        if (gameObject.tag == "sound" && gameObject == soundButton4 && sound == false && audioCheck == false)
        {
            sound = true;
            CheckMark.SetActive(true);
            soundButton1.GetComponent<SettingsButtons>().CheckMark.SetActive(true);
            soundButton2.GetComponent<SettingsButtons>().CheckMark.SetActive(true);
            soundButton3.GetComponent<SettingsButtons>().CheckMark.SetActive(true);
            soundButton1.GetComponent<SettingsButtons>().sound = true;
            soundButton2.GetComponent<SettingsButtons>().sound = true;
            soundButton3.GetComponent<SettingsButtons>().sound = true;
            audioCheck = true;
        }

        else if (gameObject.tag == "sound" && gameObject == soundButton4 && sound == true && audioCheck == false)
        {
            sound = false;
            CheckMark.SetActive(false);
            soundButton5.GetComponent<SettingsButtons>().CheckMark.SetActive(false);
            soundButton6.GetComponent<SettingsButtons>().CheckMark.SetActive(false);
            soundButton7.GetComponent<SettingsButtons>().CheckMark.SetActive(false);
            soundButton8.GetComponent<SettingsButtons>().CheckMark.SetActive(false);
            soundButton9.GetComponent<SettingsButtons>().CheckMark.SetActive(false);
            soundButton10.GetComponent<SettingsButtons>().CheckMark.SetActive(false);
            soundButton5.GetComponent<SettingsButtons>().sound = false;
            soundButton6.GetComponent<SettingsButtons>().sound = false;
            soundButton7.GetComponent<SettingsButtons>().sound = false;
            soundButton8.GetComponent<SettingsButtons>().sound = false;
            soundButton9.GetComponent<SettingsButtons>().sound = false;
            soundButton10.GetComponent<SettingsButtons>().sound = false;
            audioCheck = true;
        }

        //sound button 5

        if (gameObject.tag == "sound" && gameObject == soundButton5 && sound == false && audioCheck == false)
        {
            sound = true;
            CheckMark.SetActive(true);
            soundButton1.GetComponent<SettingsButtons>().CheckMark.SetActive(true);
            soundButton2.GetComponent<SettingsButtons>().CheckMark.SetActive(true);
            soundButton3.GetComponent<SettingsButtons>().CheckMark.SetActive(true);
            soundButton4.GetComponent<SettingsButtons>().CheckMark.SetActive(true);
            soundButton1.GetComponent<SettingsButtons>().sound = true;
            soundButton2.GetComponent<SettingsButtons>().sound = true;
            soundButton3.GetComponent<SettingsButtons>().sound = true;
            soundButton4.GetComponent<SettingsButtons>().sound = true;
            audioCheck = true;

        }

        else if (gameObject.tag == "sound" && gameObject == soundButton5 && sound == true && audioCheck == false)
        {
            sound = false;
            CheckMark.SetActive(false);
            soundButton6.GetComponent<SettingsButtons>().CheckMark.SetActive(false);
            soundButton7.GetComponent<SettingsButtons>().CheckMark.SetActive(false);
            soundButton8.GetComponent<SettingsButtons>().CheckMark.SetActive(false);
            soundButton9.GetComponent<SettingsButtons>().CheckMark.SetActive(false);
            soundButton10.GetComponent<SettingsButtons>().CheckMark.SetActive(false);
            soundButton6.GetComponent<SettingsButtons>().sound = false;
            soundButton7.GetComponent<SettingsButtons>().sound = false;
            soundButton8.GetComponent<SettingsButtons>().sound = false;
            soundButton9.GetComponent<SettingsButtons>().sound = false;
            soundButton10.GetComponent<SettingsButtons>().sound = false;
            audioCheck = true;
        }

        //sound button 6

        if (gameObject.tag == "sound" && gameObject == soundButton6 && sound == false && audioCheck == false)
        {
            sound = true;
            CheckMark.SetActive(true);
            soundButton1.GetComponent<SettingsButtons>().CheckMark.SetActive(true);
            soundButton2.GetComponent<SettingsButtons>().CheckMark.SetActive(true);
            soundButton3.GetComponent<SettingsButtons>().CheckMark.SetActive(true);
            soundButton4.GetComponent<SettingsButtons>().CheckMark.SetActive(true);
            soundButton5.GetComponent<SettingsButtons>().CheckMark.SetActive(true);
            soundButton1.GetComponent<SettingsButtons>().sound = true;
            soundButton2.GetComponent<SettingsButtons>().sound = true;
            soundButton3.GetComponent<SettingsButtons>().sound = true;
            soundButton4.GetComponent<SettingsButtons>().sound = true;
            soundButton5.GetComponent<SettingsButtons>().sound = true;
            audioCheck = true;
        }

        else if (gameObject.tag == "sound" && gameObject == soundButton6 && sound == true && audioCheck == false)
        {
            sound = false;
            CheckMark.SetActive(false);
            soundButton7.GetComponent<SettingsButtons>().CheckMark.SetActive(false);
            soundButton8.GetComponent<SettingsButtons>().CheckMark.SetActive(false);
            soundButton9.GetComponent<SettingsButtons>().CheckMark.SetActive(false);
            soundButton10.GetComponent<SettingsButtons>().CheckMark.SetActive(false);
            soundButton7.GetComponent<SettingsButtons>().sound = false;
            soundButton8.GetComponent<SettingsButtons>().sound = false;
            soundButton9.GetComponent<SettingsButtons>().sound = false;
            soundButton10.GetComponent<SettingsButtons>().sound = false;
            audioCheck = true;
        }

        //sound button 7

        if (gameObject.tag == "sound" && gameObject == soundButton7 && sound == false && audioCheck == false)
        {
            sound = true;
            CheckMark.SetActive(true);
            soundButton1.GetComponent<SettingsButtons>().CheckMark.SetActive(true);
            soundButton2.GetComponent<SettingsButtons>().CheckMark.SetActive(true);
            soundButton3.GetComponent<SettingsButtons>().CheckMark.SetActive(true);
            soundButton4.GetComponent<SettingsButtons>().CheckMark.SetActive(true);
            soundButton5.GetComponent<SettingsButtons>().CheckMark.SetActive(true);
            soundButton6.GetComponent<SettingsButtons>().CheckMark.SetActive(true);
            soundButton1.GetComponent<SettingsButtons>().sound = true;
            soundButton2.GetComponent<SettingsButtons>().sound = true;
            soundButton3.GetComponent<SettingsButtons>().sound = true;
            soundButton4.GetComponent<SettingsButtons>().sound = true;
            soundButton5.GetComponent<SettingsButtons>().sound = true;
            soundButton6.GetComponent<SettingsButtons>().sound = true;
            audioCheck = true;
        }

        else if (gameObject.tag == "sound" && gameObject == soundButton7 && sound == true && audioCheck == false)
        {
            sound = false;
            CheckMark.SetActive(false);
            soundButton8.GetComponent<SettingsButtons>().CheckMark.SetActive(false);
            soundButton9.GetComponent<SettingsButtons>().CheckMark.SetActive(false);
            soundButton10.GetComponent<SettingsButtons>().CheckMark.SetActive(false);
            soundButton8.GetComponent<SettingsButtons>().sound = false;
            soundButton9.GetComponent<SettingsButtons>().sound = false;
            soundButton10.GetComponent<SettingsButtons>().sound = false;
            audioCheck = true;
        }

        //sound button 8

        if (gameObject.tag == "sound" && gameObject == soundButton8 && sound == false && audioCheck == false)
        {
            sound = true;
            CheckMark.SetActive(true);
            soundButton1.GetComponent<SettingsButtons>().CheckMark.SetActive(true);
            soundButton2.GetComponent<SettingsButtons>().CheckMark.SetActive(true);
            soundButton3.GetComponent<SettingsButtons>().CheckMark.SetActive(true);
            soundButton4.GetComponent<SettingsButtons>().CheckMark.SetActive(true);
            soundButton5.GetComponent<SettingsButtons>().CheckMark.SetActive(true);
            soundButton6.GetComponent<SettingsButtons>().CheckMark.SetActive(true);
            soundButton7.GetComponent<SettingsButtons>().CheckMark.SetActive(true);
            soundButton1.GetComponent<SettingsButtons>().sound = true;
            soundButton2.GetComponent<SettingsButtons>().sound = true;
            soundButton3.GetComponent<SettingsButtons>().sound = true;
            soundButton4.GetComponent<SettingsButtons>().sound = true;
            soundButton5.GetComponent<SettingsButtons>().sound = true;
            soundButton6.GetComponent<SettingsButtons>().sound = true;
            soundButton7.GetComponent<SettingsButtons>().sound = true;
            audioCheck = true;
        }

        else if (gameObject.tag == "sound" && gameObject == soundButton8 && sound == true && audioCheck == false)
        {
            sound = false;
            CheckMark.SetActive(false);
            soundButton9.GetComponent<SettingsButtons>().CheckMark.SetActive(false);
            soundButton10.GetComponent<SettingsButtons>().CheckMark.SetActive(false);
            soundButton9.GetComponent<SettingsButtons>().sound = false;
            soundButton10.GetComponent<SettingsButtons>().sound = false;
            audioCheck = true;
        }

        //sound button 9

        if (gameObject.tag == "sound" && gameObject == soundButton9 && sound == false && audioCheck == false)
        {
            sound = true;
            CheckMark.SetActive(true);
            soundButton1.GetComponent<SettingsButtons>().CheckMark.SetActive(true);
            soundButton2.GetComponent<SettingsButtons>().CheckMark.SetActive(true);
            soundButton3.GetComponent<SettingsButtons>().CheckMark.SetActive(true);
            soundButton4.GetComponent<SettingsButtons>().CheckMark.SetActive(true);
            soundButton5.GetComponent<SettingsButtons>().CheckMark.SetActive(true);
            soundButton6.GetComponent<SettingsButtons>().CheckMark.SetActive(true);
            soundButton7.GetComponent<SettingsButtons>().CheckMark.SetActive(true);
            soundButton8.GetComponent<SettingsButtons>().CheckMark.SetActive(true);
            soundButton1.GetComponent<SettingsButtons>().sound = true;
            soundButton2.GetComponent<SettingsButtons>().sound = true;
            soundButton3.GetComponent<SettingsButtons>().sound = true;
            soundButton4.GetComponent<SettingsButtons>().sound = true;
            soundButton5.GetComponent<SettingsButtons>().sound = true;
            soundButton6.GetComponent<SettingsButtons>().sound = true;
            soundButton7.GetComponent<SettingsButtons>().sound = true;
            soundButton8.GetComponent<SettingsButtons>().sound = true;
            audioCheck = true;
        }

        else if (gameObject.tag == "sound" && gameObject == soundButton9 && sound == true && audioCheck == false)
        {
            sound = false;
            CheckMark.SetActive(false);
            soundButton10.GetComponent<SettingsButtons>().CheckMark.SetActive(false);
            soundButton10.GetComponent<SettingsButtons>().sound = false;
            audioCheck = true;
        }

        //sound button 10

        if (gameObject.tag == "sound" && gameObject == soundButton10 && sound == false && audioCheck == false)
        {
            sound = true;
            CheckMark.SetActive(true);
            soundButton1.GetComponent<SettingsButtons>().CheckMark.SetActive(true);
            soundButton2.GetComponent<SettingsButtons>().CheckMark.SetActive(true);
            soundButton3.GetComponent<SettingsButtons>().CheckMark.SetActive(true);
            soundButton4.GetComponent<SettingsButtons>().CheckMark.SetActive(true);
            soundButton5.GetComponent<SettingsButtons>().CheckMark.SetActive(true);
            soundButton6.GetComponent<SettingsButtons>().CheckMark.SetActive(true);
            soundButton7.GetComponent<SettingsButtons>().CheckMark.SetActive(true);
            soundButton8.GetComponent<SettingsButtons>().CheckMark.SetActive(true);
            soundButton9.GetComponent<SettingsButtons>().CheckMark.SetActive(true);
            soundButton1.GetComponent<SettingsButtons>().sound = true;
            soundButton2.GetComponent<SettingsButtons>().sound = true;
            soundButton3.GetComponent<SettingsButtons>().sound = true;
            soundButton4.GetComponent<SettingsButtons>().sound = true;
            soundButton5.GetComponent<SettingsButtons>().sound = true;
            soundButton6.GetComponent<SettingsButtons>().sound = true;
            soundButton7.GetComponent<SettingsButtons>().sound = true;
            soundButton8.GetComponent<SettingsButtons>().sound = true;
            soundButton9.GetComponent<SettingsButtons>().sound = true;
            audioCheck = true;
        }

        else if (gameObject.tag == "sound" && gameObject == soundButton10 && sound == true && audioCheck == false)
        {
            sound = false;
            CheckMark.SetActive(false);
            audioCheck = true;
        }






        //Music Button Functionality

        //music button 1

        if (gameObject.tag == "music" && gameObject == musicButton1 && music == false && audioCheck == false)
        {
            music = true;
            CheckMark.SetActive(true);
            audioCheck = true;
        }

        else if (gameObject.tag == "music" && gameObject == musicButton1 && music == true && audioCheck == false)
        {
            music = false;
            CheckMark.SetActive(false);
            musicButton2.GetComponent<SettingsButtons>().CheckMark.SetActive(false);
            musicButton3.GetComponent<SettingsButtons>().CheckMark.SetActive(false);
            musicButton4.GetComponent<SettingsButtons>().CheckMark.SetActive(false);
            musicButton5.GetComponent<SettingsButtons>().CheckMark.SetActive(false);
            musicButton6.GetComponent<SettingsButtons>().CheckMark.SetActive(false);
            musicButton7.GetComponent<SettingsButtons>().CheckMark.SetActive(false);
            musicButton8.GetComponent<SettingsButtons>().CheckMark.SetActive(false);
            musicButton9.GetComponent<SettingsButtons>().CheckMark.SetActive(false);
            musicButton10.GetComponent<SettingsButtons>().CheckMark.SetActive(false);
            musicButton2.GetComponent<SettingsButtons>().music = false;
            musicButton3.GetComponent<SettingsButtons>().music = false;
            musicButton4.GetComponent<SettingsButtons>().music = false;
            musicButton5.GetComponent<SettingsButtons>().music = false;
            musicButton6.GetComponent<SettingsButtons>().music = false;
            musicButton7.GetComponent<SettingsButtons>().music = false;
            musicButton8.GetComponent<SettingsButtons>().music = false;
            musicButton9.GetComponent<SettingsButtons>().music = false;
            musicButton10.GetComponent<SettingsButtons>().music = false;
            audioCheck = true;
        }

        //music button 2

        if (gameObject.tag == "music" && gameObject == musicButton2 && music == false && audioCheck == false)
        {
            music = true;
            CheckMark.SetActive(true);
            musicButton1.GetComponent<SettingsButtons>().CheckMark.SetActive(true);
            musicButton1.GetComponent<SettingsButtons>().music = true;
            audioCheck = true;
        }

        else if (gameObject.tag == "music" && gameObject == musicButton2 && music == true && audioCheck == false)
        {
            music = false;
            CheckMark.SetActive(false);
            musicButton3.GetComponent<SettingsButtons>().CheckMark.SetActive(false);
            musicButton4.GetComponent<SettingsButtons>().CheckMark.SetActive(false);
            musicButton5.GetComponent<SettingsButtons>().CheckMark.SetActive(false);
            musicButton6.GetComponent<SettingsButtons>().CheckMark.SetActive(false);
            musicButton7.GetComponent<SettingsButtons>().CheckMark.SetActive(false);
            musicButton8.GetComponent<SettingsButtons>().CheckMark.SetActive(false);
            musicButton9.GetComponent<SettingsButtons>().CheckMark.SetActive(false);
            musicButton10.GetComponent<SettingsButtons>().CheckMark.SetActive(false);
            musicButton3.GetComponent<SettingsButtons>().music = false;
            musicButton4.GetComponent<SettingsButtons>().music = false;
            musicButton5.GetComponent<SettingsButtons>().music = false;
            musicButton6.GetComponent<SettingsButtons>().music = false;
            musicButton7.GetComponent<SettingsButtons>().music = false;
            musicButton8.GetComponent<SettingsButtons>().music = false;
            musicButton9.GetComponent<SettingsButtons>().music = false;
            musicButton10.GetComponent<SettingsButtons>().music = false;
            audioCheck = true;
        }

        //music button 3

        if (gameObject.tag == "music" && gameObject == musicButton3 && music == false && audioCheck == false)
        {
            music = true;
            CheckMark.SetActive(true);
            musicButton1.GetComponent<SettingsButtons>().CheckMark.SetActive(true);
            musicButton2.GetComponent<SettingsButtons>().CheckMark.SetActive(true);
            musicButton1.GetComponent<SettingsButtons>().music = true;
            musicButton2.GetComponent<SettingsButtons>().music = true;
            audioCheck = true;
        }

        else if (gameObject.tag == "music" && gameObject == musicButton3 && music == true && audioCheck == false)
        {
            music = false;
            CheckMark.SetActive(false);
            musicButton4.GetComponent<SettingsButtons>().CheckMark.SetActive(false);
            musicButton5.GetComponent<SettingsButtons>().CheckMark.SetActive(false);
            musicButton6.GetComponent<SettingsButtons>().CheckMark.SetActive(false);
            musicButton7.GetComponent<SettingsButtons>().CheckMark.SetActive(false);
            musicButton8.GetComponent<SettingsButtons>().CheckMark.SetActive(false);
            musicButton9.GetComponent<SettingsButtons>().CheckMark.SetActive(false);
            musicButton10.GetComponent<SettingsButtons>().CheckMark.SetActive(false);
            musicButton4.GetComponent<SettingsButtons>().music = false;
            musicButton5.GetComponent<SettingsButtons>().music = false;
            musicButton6.GetComponent<SettingsButtons>().music = false;
            musicButton7.GetComponent<SettingsButtons>().music = false;
            musicButton8.GetComponent<SettingsButtons>().music = false;
            musicButton9.GetComponent<SettingsButtons>().music = false;
            musicButton10.GetComponent<SettingsButtons>().music = false;
            audioCheck = true;
        }

        //music button 4

        if (gameObject.tag == "music" && gameObject == musicButton4 && music == false && audioCheck == false)
        {
            music = true;
            CheckMark.SetActive(true);
            musicButton1.GetComponent<SettingsButtons>().CheckMark.SetActive(true);
            musicButton2.GetComponent<SettingsButtons>().CheckMark.SetActive(true);
            musicButton3.GetComponent<SettingsButtons>().CheckMark.SetActive(true);
            musicButton1.GetComponent<SettingsButtons>().music = true;
            musicButton2.GetComponent<SettingsButtons>().music = true;
            musicButton3.GetComponent<SettingsButtons>().music = true;
            audioCheck = true;
        }

        else if (gameObject.tag == "music" && gameObject == musicButton4 && music == true && audioCheck == false)
        {
            music = false;
            CheckMark.SetActive(false);
            musicButton5.GetComponent<SettingsButtons>().CheckMark.SetActive(false);
            musicButton6.GetComponent<SettingsButtons>().CheckMark.SetActive(false);
            musicButton7.GetComponent<SettingsButtons>().CheckMark.SetActive(false);
            musicButton8.GetComponent<SettingsButtons>().CheckMark.SetActive(false);
            musicButton9.GetComponent<SettingsButtons>().CheckMark.SetActive(false);
            musicButton10.GetComponent<SettingsButtons>().CheckMark.SetActive(false);
            musicButton5.GetComponent<SettingsButtons>().music = false;
            musicButton6.GetComponent<SettingsButtons>().music = false;
            musicButton7.GetComponent<SettingsButtons>().music = false;
            musicButton8.GetComponent<SettingsButtons>().music = false;
            musicButton9.GetComponent<SettingsButtons>().music = false;
            musicButton10.GetComponent<SettingsButtons>().music = false;
            audioCheck = true;
        }

        //music button 5

        if (gameObject.tag == "music" && gameObject == musicButton5 && music == false && audioCheck == false)
        {
            music = true;
            CheckMark.SetActive(true);
            musicButton1.GetComponent<SettingsButtons>().CheckMark.SetActive(true);
            musicButton2.GetComponent<SettingsButtons>().CheckMark.SetActive(true);
            musicButton3.GetComponent<SettingsButtons>().CheckMark.SetActive(true);
            musicButton4.GetComponent<SettingsButtons>().CheckMark.SetActive(true);
            musicButton1.GetComponent<SettingsButtons>().music = true;
            musicButton2.GetComponent<SettingsButtons>().music = true;
            musicButton3.GetComponent<SettingsButtons>().music = true;
            musicButton4.GetComponent<SettingsButtons>().music = true;
            audioCheck = true;

        }

        else if (gameObject.tag == "music" && gameObject == musicButton5 && music == true && audioCheck == false)
        {
            music = false;
            CheckMark.SetActive(false);
            musicButton6.GetComponent<SettingsButtons>().CheckMark.SetActive(false);
            musicButton7.GetComponent<SettingsButtons>().CheckMark.SetActive(false);
            musicButton8.GetComponent<SettingsButtons>().CheckMark.SetActive(false);
            musicButton9.GetComponent<SettingsButtons>().CheckMark.SetActive(false);
            musicButton10.GetComponent<SettingsButtons>().CheckMark.SetActive(false);
            musicButton6.GetComponent<SettingsButtons>().music = false;
            musicButton7.GetComponent<SettingsButtons>().music = false;
            musicButton8.GetComponent<SettingsButtons>().music = false;
            musicButton9.GetComponent<SettingsButtons>().music = false;
            musicButton10.GetComponent<SettingsButtons>().music = false;
            audioCheck = true;
        }

        //music button 6

        if (gameObject.tag == "music" && gameObject == musicButton6 && music == false && audioCheck == false)
        {
            music = true;
            CheckMark.SetActive(true);
            musicButton1.GetComponent<SettingsButtons>().CheckMark.SetActive(true);
            musicButton2.GetComponent<SettingsButtons>().CheckMark.SetActive(true);
            musicButton3.GetComponent<SettingsButtons>().CheckMark.SetActive(true);
            musicButton4.GetComponent<SettingsButtons>().CheckMark.SetActive(true);
            musicButton5.GetComponent<SettingsButtons>().CheckMark.SetActive(true);
            musicButton1.GetComponent<SettingsButtons>().music = true;
            musicButton2.GetComponent<SettingsButtons>().music = true;
            musicButton3.GetComponent<SettingsButtons>().music = true;
            musicButton4.GetComponent<SettingsButtons>().music = true;
            musicButton5.GetComponent<SettingsButtons>().music = true;
            audioCheck = true;
        }

        else if (gameObject.tag == "music" && gameObject == musicButton6 && music == true && audioCheck == false)
        {
            music = false;
            CheckMark.SetActive(false);
            musicButton7.GetComponent<SettingsButtons>().CheckMark.SetActive(false);
            musicButton8.GetComponent<SettingsButtons>().CheckMark.SetActive(false);
            musicButton9.GetComponent<SettingsButtons>().CheckMark.SetActive(false);
            musicButton10.GetComponent<SettingsButtons>().CheckMark.SetActive(false);
            musicButton7.GetComponent<SettingsButtons>().music = false;
            musicButton8.GetComponent<SettingsButtons>().music = false;
            musicButton9.GetComponent<SettingsButtons>().music = false;
            musicButton10.GetComponent<SettingsButtons>().music = false;
            audioCheck = true;
        }

        //music button 7

        if (gameObject.tag == "music" && gameObject == musicButton7 && music == false && audioCheck == false)
        {
            music = true;
            CheckMark.SetActive(true);
            musicButton1.GetComponent<SettingsButtons>().CheckMark.SetActive(true);
            musicButton2.GetComponent<SettingsButtons>().CheckMark.SetActive(true);
            musicButton3.GetComponent<SettingsButtons>().CheckMark.SetActive(true);
            musicButton4.GetComponent<SettingsButtons>().CheckMark.SetActive(true);
            musicButton5.GetComponent<SettingsButtons>().CheckMark.SetActive(true);
            musicButton6.GetComponent<SettingsButtons>().CheckMark.SetActive(true);
            musicButton1.GetComponent<SettingsButtons>().music = true;
            musicButton2.GetComponent<SettingsButtons>().music = true;
            musicButton3.GetComponent<SettingsButtons>().music = true;
            musicButton4.GetComponent<SettingsButtons>().music = true;
            musicButton5.GetComponent<SettingsButtons>().music = true;
            musicButton6.GetComponent<SettingsButtons>().music = true;
            audioCheck = true;
        }

        else if (gameObject.tag == "music" && gameObject == musicButton7 && music == true && audioCheck == false)
        {
            music = false;
            CheckMark.SetActive(false);
            musicButton8.GetComponent<SettingsButtons>().CheckMark.SetActive(false);
            musicButton9.GetComponent<SettingsButtons>().CheckMark.SetActive(false);
            musicButton10.GetComponent<SettingsButtons>().CheckMark.SetActive(false);
            musicButton8.GetComponent<SettingsButtons>().music = false;
            musicButton9.GetComponent<SettingsButtons>().music = false;
            musicButton10.GetComponent<SettingsButtons>().music = false;
            audioCheck = true;
        }

        //music button 8

        if (gameObject.tag == "music" && gameObject == musicButton8 && music == false && audioCheck == false)
        {
            music = true;
            CheckMark.SetActive(true);
            musicButton1.GetComponent<SettingsButtons>().CheckMark.SetActive(true);
            musicButton2.GetComponent<SettingsButtons>().CheckMark.SetActive(true);
            musicButton3.GetComponent<SettingsButtons>().CheckMark.SetActive(true);
            musicButton4.GetComponent<SettingsButtons>().CheckMark.SetActive(true);
            musicButton5.GetComponent<SettingsButtons>().CheckMark.SetActive(true);
            musicButton6.GetComponent<SettingsButtons>().CheckMark.SetActive(true);
            musicButton7.GetComponent<SettingsButtons>().CheckMark.SetActive(true);
            musicButton1.GetComponent<SettingsButtons>().music = true;
            musicButton2.GetComponent<SettingsButtons>().music = true;
            musicButton3.GetComponent<SettingsButtons>().music = true;
            musicButton4.GetComponent<SettingsButtons>().music = true;
            musicButton5.GetComponent<SettingsButtons>().music = true;
            musicButton6.GetComponent<SettingsButtons>().music = true;
            musicButton7.GetComponent<SettingsButtons>().music = true;
            audioCheck = true;
        }

        else if (gameObject.tag == "music" && gameObject == musicButton8 && music == true && audioCheck == false)
        {
            music = false;
            CheckMark.SetActive(false);
            musicButton9.GetComponent<SettingsButtons>().CheckMark.SetActive(false);
            musicButton10.GetComponent<SettingsButtons>().CheckMark.SetActive(false);
            musicButton9.GetComponent<SettingsButtons>().music = false;
            musicButton10.GetComponent<SettingsButtons>().music = false;
            audioCheck = true;
        }

        //music button 9

        if (gameObject.tag == "music" && gameObject == musicButton9 && music == false && audioCheck == false)
        {
            music = true;
            CheckMark.SetActive(true);
            musicButton1.GetComponent<SettingsButtons>().CheckMark.SetActive(true);
            musicButton2.GetComponent<SettingsButtons>().CheckMark.SetActive(true);
            musicButton3.GetComponent<SettingsButtons>().CheckMark.SetActive(true);
            musicButton4.GetComponent<SettingsButtons>().CheckMark.SetActive(true);
            musicButton5.GetComponent<SettingsButtons>().CheckMark.SetActive(true);
            musicButton6.GetComponent<SettingsButtons>().CheckMark.SetActive(true);
            musicButton7.GetComponent<SettingsButtons>().CheckMark.SetActive(true);
            musicButton8.GetComponent<SettingsButtons>().CheckMark.SetActive(true);
            musicButton1.GetComponent<SettingsButtons>().music = true;
            musicButton2.GetComponent<SettingsButtons>().music = true;
            musicButton3.GetComponent<SettingsButtons>().music = true;
            musicButton5.GetComponent<SettingsButtons>().music = true;
            musicButton6.GetComponent<SettingsButtons>().music = true;
            musicButton7.GetComponent<SettingsButtons>().music = true;
            musicButton8.GetComponent<SettingsButtons>().music = true;
            audioCheck = true;
        }

        else if (gameObject.tag == "music" && gameObject == musicButton9 && music == true && audioCheck == false)
        {
            music = false;
            CheckMark.SetActive(false);
            musicButton10.GetComponent<SettingsButtons>().CheckMark.SetActive(false);
            musicButton10.GetComponent<SettingsButtons>().music = false;
            audioCheck = true;
        }

        //music button 10

        if (gameObject.tag == "music" && gameObject == musicButton10 && music == false && audioCheck == false)
        {
            music = true;
            CheckMark.SetActive(true);
            musicButton1.GetComponent<SettingsButtons>().CheckMark.SetActive(true);
            musicButton2.GetComponent<SettingsButtons>().CheckMark.SetActive(true);
            musicButton3.GetComponent<SettingsButtons>().CheckMark.SetActive(true);
            musicButton4.GetComponent<SettingsButtons>().CheckMark.SetActive(true);
            musicButton5.GetComponent<SettingsButtons>().CheckMark.SetActive(true);
            musicButton6.GetComponent<SettingsButtons>().CheckMark.SetActive(true);
            musicButton7.GetComponent<SettingsButtons>().CheckMark.SetActive(true);
            musicButton8.GetComponent<SettingsButtons>().CheckMark.SetActive(true);
            musicButton9.GetComponent<SettingsButtons>().CheckMark.SetActive(true);
            musicButton1.GetComponent<SettingsButtons>().music = true;
            musicButton2.GetComponent<SettingsButtons>().music = true;
            musicButton3.GetComponent<SettingsButtons>().music = true;
            musicButton4.GetComponent<SettingsButtons>().music = true;
            musicButton5.GetComponent<SettingsButtons>().music = true;
            musicButton6.GetComponent<SettingsButtons>().music = true;
            musicButton7.GetComponent<SettingsButtons>().music = true;
            musicButton8.GetComponent<SettingsButtons>().music = true;
            musicButton9.GetComponent<SettingsButtons>().music = true;
            audioCheck = true;
        }

        else if (gameObject.tag == "music" && gameObject == musicButton10 && music == true && audioCheck == false)
        {
            music = false;
            CheckMark.SetActive(false);
            audioCheck = true;
        }


        audioCheck = false;
    }
}

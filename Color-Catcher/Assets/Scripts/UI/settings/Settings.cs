using UnityEngine;
using UnityEngine.SceneManagement;

public class Settings : MonoBehaviour
{
    public GameObject settingsMenu;
    public PlayerMovement pm;

    public AudioSource musicAudio;
    public AudioSource soundAudio;
    public AudioSource groundAudio;

    public bool music = true;
    public bool sound = true;

    public void openSettings(){
        pm.CanPlay = false;
        settingsMenu.SetActive(true);
        pm.move.x = 0;
    }
    public void resume(){
        pm.CanPlay = true;
        settingsMenu.SetActive(false);
    }
    public void Quit(){
        SceneManager.LoadScene("Main Menu");
    }

    public void musicvoid(){
        if(music){
            musicAudio.mute = true;
            music = false;
        }else{
            musicAudio.mute = false;
            music = true;
        }
    }
    public void soundvoid(){
        if(sound){
            soundAudio.mute = true;
            groundAudio.mute = true;
            sound = false;
        }else{
            soundAudio.mute = false;
            groundAudio.mute = false;
            sound = true;
        }
    }
}

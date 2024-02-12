using UnityEngine;
using UnityEngine.SceneManagement;

public class Settings : MonoBehaviour
{
    public GameObject settingsMenu;
    public PlayerMovement pm;


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
}

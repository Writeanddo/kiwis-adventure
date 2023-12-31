using UnityEngine;
using UnityEngine.SceneManagement;
using SB.Runtime;

public class PauseManager : MonoBehaviour
{

    [SerializeField] int menuScene;
    [SerializeField] GameObject canvasMenu;
    [SerializeField] GameObject pauseButton;
    public SBShuffleBoardScript sbController;

    public static PauseManager pauseManager;

    void Start()
    {
        pauseManager = this;
        canvasMenu.SetActive(false);
    }

    public void Pause() 
    {
        Time.timeScale = 0f;
        //TODO Change into event
        canvasMenu.SetActive(true);
    }

    public void Resume()
    {
        Time.timeScale = 1f;
        //TODO Change into event
        canvasMenu.SetActive(false);
    }


    public void RetryLevel()
    {
        Time.timeScale = 1f;
        //Time.timeScale = 1f;
        sbController.ResetBoard();
        Resume();
    }
    
    public void ReturnToMenu()
    {
        sbController.DestroyBoard();
        Time.timeScale = 1f;
        //Time.timeScale = 1f;
        SceneManager.LoadScene(menuScene);
    }

    public void Quit()
    {
        Application.Quit();
    }

}

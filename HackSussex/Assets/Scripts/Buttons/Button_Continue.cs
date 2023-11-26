
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button_Continue : MonoBehaviour
{
    public void GoToScene(string Menu)
    {
        SceneManager.LoadScene(Menu);
    }

    public void QuitApp()
    {
        Application.Quit();
        Debug.Log("Appliction has quit");
    }
 
}

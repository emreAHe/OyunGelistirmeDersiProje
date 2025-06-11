using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuControll : MonoBehaviour
{
    public void PlayBTN()
    {
        SceneManager.LoadScene("GamePlay");
    }

    public void QuitBTN()
    {
        Application.Quit();
    }
}

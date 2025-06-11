using UnityEngine;
using UnityEngine.SceneManagement;


public class OyunuBaslatma : MonoBehaviour
{
    public GameObject player;
    public GameObject Lineyer;
    public GameObject StartScreen;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            player.SetActive(true);
            Lineyer.SetActive(true);
            StartScreen.SetActive(false);
        }
    }

    public void MenuyeDon()
    {
        SceneManager.LoadScene("Menu");
    }
}

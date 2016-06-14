using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuButtonController : MonoBehaviour
{

    public Canvas Menu;
    public Button NewButton;
    public Button ExitButton;

    // Use this for initialization
    void Start()
    {
        Menu = Menu.GetComponent<Canvas>();
        NewButton = NewButton.GetComponent<Button>();
        ExitButton = ExitButton.GetComponent<Button>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void StartLevel()
    {
        SceneManager.LoadScene(1);
        Debug.Log("starting");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}

using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public void UI_MenuChoixLevel()
    {
        SceneManager.LoadScene("MenuChoixLevel");
    }
    public void UI_Guide()
    {
        SceneManager.LoadScene("MenuGuide");
    }
    public void UI_Exit()
    {
        Application.Quit();
    }

    public void UI_Menu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void UI_Level1()
    {
        SceneManager.LoadScene("Level1");
    }
    public void UI_Level2()
    {
        SceneManager.LoadScene("Level2");
    }
    public void UI_Level3()
    {
        SceneManager.LoadScene("Level3");
    }
    public void UI_Level4()
    {
        SceneManager.LoadScene("Level4");
    }
    public void UI_Level5()
    {
        SceneManager.LoadScene("Level5");
    }
    public void UI_Level6()
    {
        SceneManager.LoadScene("Level6");
    }

}

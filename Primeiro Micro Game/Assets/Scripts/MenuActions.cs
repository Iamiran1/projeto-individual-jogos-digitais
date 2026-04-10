using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuActions : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void IniciaJogo()
    {
        GameController.Init();

        SceneManager.LoadScene(1);
    }

    public void Menu()
    {
        SceneManager.LoadScene(0);
    }
    public void Sair()
    {
        Application.Quit();
    }
    
    public void Reinciar()
    {
        GameController.Restart();

        SceneManager.LoadScene(1);
    }

}

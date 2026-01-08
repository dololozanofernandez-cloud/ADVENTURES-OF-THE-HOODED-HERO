using UnityEngine;
using UnityEngine.SceneManagement;

public class Botones : MonoBehaviour
{
    public  void Iniciar()
    {
        SceneManager.LoadScene("Escena1");
    }
    public void Salir()
    {
        Application.Quit();
    }
}

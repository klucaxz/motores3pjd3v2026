using UnityEngine;

public class MenuUI : MonoBehaviour
{
    public void IniciarJogo()
    {
        GameManager.Instancia.DefinirEstado(GameManager.EstadoJogo.Gameplay);
        GameManager.Instancia.CarregarCena("GetStarted_Scene");
    }

    public void SairJogo()
    {
        Application.Quit();
    }
}   
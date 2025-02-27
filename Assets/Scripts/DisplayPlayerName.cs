using UnityEngine;
using UnityEngine.UI; // Asegura que esta línea está presente

public class DisplayPlayerName : MonoBehaviour
{
    public UnityEngine.UI.Text playerNameText; // Especifica explícitamente que es de UnityEngine.UI

    void Start()
    {
        if (PlayerPrefs.HasKey("PlayerName"))
        {
            playerNameText.text = "Jugador: " + PlayerPrefs.GetString("PlayerName");
        }
    }
}

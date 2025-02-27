using UnityEngine;
using UnityEngine.UI; // Asegura que esta l�nea est� presente

public class DisplayPlayerName : MonoBehaviour
{
    public UnityEngine.UI.Text playerNameText; // Especifica expl�citamente que es de UnityEngine.UI

    void Start()
    {
        if (PlayerPrefs.HasKey("PlayerName"))
        {
            playerNameText.text = "Jugador: " + PlayerPrefs.GetString("PlayerName");
        }
    }
}

using UnityEngine;
using UnityEngine.SceneManagement; 

public class MainMenu : MonoBehaviour
{
    [Header("Audio de gros rigolo")]
    public AudioSource audioSource;    
    public AudioClip sonPtdr;          

    [Header("NomdelaScenenSTP")]
    public string nomDeLaScene = "TAMERE"; 

    
    public void PlayGame(string enzobabes)
    {
        Debug.Log("Lancement du jeu... Bebou va jouer !");
        SceneManager.LoadScene(enzobabes);
    }

    public void BoutonPtdr()
    {
        Debug.Log("PTDRRRR t'as cliqué bg <3");

        
        if (audioSource != null && sonPtdr != null)
        {
            
            audioSource.PlayOneShot(sonPtdr);
        }
        else
        {
            Debug.LogWarning(" il manque l'AudioSource");
        }
    }

    
    public void QuitGame()
    {
        Debug.Log("Fermeture du jeu. Bye sale chien !");
        Application.Quit(); 
    }
}
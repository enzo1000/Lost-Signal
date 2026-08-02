using System.Collections;
using TMPro;
using UnityEngine;

public class End_game : MonoBehaviour
{
    [Header("a mettre connard")]
    public CanvasGroup fondNoir;
    public CanvasGroup texteGroup;
    public TMP_Text texte;

    [Header("Reglages")]
    public float vitesseFondu = 1.5f;
    public float tempsLecture = 2f;

    public void JouerSequence(params string[] messages)
    {
        StartCoroutine(Sequence(messages));
    }

    IEnumerator Sequence(string[] messages)
    {
        
        //yield return temps_fondu(fondNoir, 0, 1);

        foreach (string message in messages)
        {
            texte.text = message;

            
            yield return temps_fondu(texteGroup, 0, 1);

            yield return new WaitForSeconds(tempsLecture);

            
            yield return temps_fondu(texteGroup, 1, 0);

            yield return new WaitForSeconds(0.3f);
        }

    }

    IEnumerator temps_fondu(CanvasGroup canvas, float debut, float fin)
    {
        float t = 0;

        while (t < vitesseFondu)
        {
            t += Time.deltaTime;
            canvas.alpha = Mathf.Lerp(debut, fin, t / vitesseFondu);
            yield return null;
        }
        
    }

        void Start()
    {
        JouerSequence(
            "You are alone.",
            "You can barely see anything out there",
            "No one is going to save you now",
            "You are alone...",
            "It's just so cold out there",
            "It's your end..."
             );
    }

}

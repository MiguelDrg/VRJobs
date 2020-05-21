using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class video : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        //On définit les bases
        //Image Noir de Fade de scène
        GameObject ImageFade = GameObject.Find("BlackImage");
        CanvasGroup canvasGroup = ImageFade.GetComponent<CanvasGroup>();
        //Message d'info1
        GameObject infoOne = GameObject.Find("infoPane");
        CanvasGroup canvasGroupInfoOne = infoOne.GetComponent<CanvasGroup>();
        canvasGroupInfoOne.alpha = 0;
        //Message d'info2
        GameObject infoTwo = GameObject.Find("infoPane2");
        CanvasGroup canvasGroupInfoTwo = infoTwo.GetComponent<CanvasGroup>();
        canvasGroupInfoTwo.alpha = 0;

        //On lance la scène
        StartCoroutine(Routine(canvasGroupInfoOne, canvasGroupInfoTwo, canvasGroup));
        //Screen.lockCursor = true;
    }

    private IEnumerator Routine(CanvasGroup canvasGroupInfoOne, CanvasGroup canvasGroupInfoTwo, CanvasGroup canvasGroup)
    {
        //On fade IN PUIS ON LANCE
        StartCoroutine(FadeEffect.FadeCanvas(canvasGroup, 1, 0, 2));
        GameObject video = GameObject.Find("360_VR Master Series _ Free Download _ London On Tower Bridge");
        var videoPlayer = video.GetComponent<UnityEngine.Video.VideoPlayer>();
        videoPlayer.Play();
        //ON AFFICHE LES 1E INFOS
        yield return new WaitForSeconds(2);
        StartCoroutine(FadeEffect.FadeCanvas(canvasGroupInfoOne, 0, 1, 1));
        yield return new WaitForSeconds(8);
        StartCoroutine(FadeEffect.FadeCanvas(canvasGroupInfoOne, 1, 0, 1));
        StartCoroutine(FadeEffect.FadeCanvas(canvasGroupInfoTwo, 0, 1, 1));
        yield return new WaitForSeconds(8);
        StartCoroutine(FadeEffect.FadeCanvas(canvasGroupInfoTwo, 1, 0, 1));
        StartCoroutine(FadeEffect.FadeCanvas(canvasGroup, 0, 1, 2));
        yield return new WaitForSeconds(2);
        videoPlayer.Pause();
        Application.LoadLevel("MainScene");

    }
}

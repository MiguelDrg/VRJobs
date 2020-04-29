using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class ControllerHit : MonoBehaviour
{

    public RaycastHit _Hit;


    void Start()
    {
        //On définit les bases
        //Image Noir de Fade de scène
        GameObject ImageFade = GameObject.Find("BlackImage");
        CanvasGroup canvasGroup = ImageFade.GetComponent<CanvasGroup>();
        StartCoroutine(FadeEffect.FadeCanvas(canvasGroup, 1, 0, 2));
    }

    void Update()
    {
        GameObject CamObject = GameObject.Find("GearVrController");
        Vector2 center = CamObject.transform.position;

        // Example: check if touchpad was just touched
        if (true)
        {
            // Do something.
            // TouchDown is true for 1 frame after touchpad is touched.

            PointerEventData pointerData = new PointerEventData(EventSystem.current);

            pointerData.position = center;

            List<RaycastResult> results = new List<RaycastResult>();
            EventSystem.current.RaycastAll(pointerData, results);

            if (results.Count > 0)
            {
                //WorldUI is my layer name
                if (/*(Input.GetMouseButtonDown(0))*/ results[0].gameObject.layer == LayerMask.NameToLayer("UI"))
                {
                    if ((results[results.Count - 1].gameObject.name) == "Button360")
                    {
                        GameObject ImageFade = GameObject.Find("BlackImage");
                        CanvasGroup canvasGroup = ImageFade.GetComponent<CanvasGroup>();
                        StartCoroutine(FadeEffect.FadeCanvas(canvasGroup, 0, 1, 2));
                        Application.LoadLevel("London Video");
                    }
                    if ((results[results.Count - 1].gameObject.name) == "ButtonPratique")
                    {
                        GameObject ImageFade = GameObject.Find("BlackImage");
                        CanvasGroup canvasGroup = ImageFade.GetComponent<CanvasGroup>();
                        StartCoroutine(FadeEffect.FadeCanvas(canvasGroup, 0, 1, 2));
                        Application.LoadLevel("Scène_2");
                    }


                    string dbg = "Root Element: {0} \n GrandChild Element: {1}";
                    Debug.Log(string.Format(dbg, results[results.Count - 1].gameObject.name, results[0].gameObject.name));
                    //Debug.Log("Root Element: "+results[results.Count-1].gameObject.name);
                    //Debug.Log("GrandChild Element: "+results[0].gameObject.name);
                    results.Clear();
                }
            }
        }
    }

    private void FixedUpdate()
    {



        if ((Input.GetKeyDown(KeyCode.M) && SceneManager.GetActiveScene().name == "Scène_2"))
        {
            GameObject ImageFade = GameObject.Find("BlackImage");
            CanvasGroup canvasGroup = ImageFade.GetComponent<CanvasGroup>();
            StartCoroutine(FadeEffect.FadeCanvas(canvasGroup, 0, 1, 2));
            Application.LoadLevel("MainScene");
        }


    }
}

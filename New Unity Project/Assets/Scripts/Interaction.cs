using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;


public class Interaction : MonoBehaviour
{

    public Text textshowed = null;
    public void changeWord (string word)
    {
        textshowed.text = word;
    }
}

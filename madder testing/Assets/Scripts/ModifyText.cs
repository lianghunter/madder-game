using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ModifyText : MonoBehaviour
{
    public TMP_Text outputText;
    
    public void changeText(string newText)
    {
        outputText.text = newText;
    }
}

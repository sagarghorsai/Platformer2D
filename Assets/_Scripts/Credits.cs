using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Credits : MonoBehaviour
{
    public TextMeshProUGUI textMeshPro;
    public string textToType;
    public float typingSpeed = 0.1f;

    private void Start()
    {
        StartCoroutine(TypeTextRoutine());
    }

    private IEnumerator TypeTextRoutine()
    {
        textMeshPro.text = ""; 

        foreach (char letter in textToType)
        {
            textMeshPro.text += letter; 
            yield return new WaitForSeconds(typingSpeed); 
        }
    }
}




using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
/*

 */
public class DisplayGuessCount : MonoBehaviour
{

    [SerializeField] TextMeshProUGUI guessTextCounter;
    // Start is called before the first frame update
    void Start()
    {
        int guessNum = NumberWizard.GetGuessCounter();
        guessTextCounter.text = guessNum.ToString();
    }


}

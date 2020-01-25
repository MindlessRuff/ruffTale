using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class IcePuppy : MonoBehaviour
{
    public GameObject dialogBox;
    TextMeshPro dialogText;
    int dialogCount = 0;

    // Start is called before the first frame update
    void Start()
    {
        dialogBox.SetActive(false);
        dialogCount = 0;
        dialogText = GetComponent<TextMeshPro>();
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void advanceDialog() {
        if (dialogCount == 0)
        {
            dialogBox.SetActive(true);
            dialogText.text = "Success"; 
        }
    }
}

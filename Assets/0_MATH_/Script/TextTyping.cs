using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TextTyping : MonoBehaviour
{
    public float typingSpeed = 0.1f; // 글자 하나가 나타나는 속도
    private Text textMesh; // TextMeshPro UI 컴포넌트
    private string fullText; // 전체 텍스트
    private string currentText = ""; // 현재까지 표시된 텍스트
    private int index = 0; // 현재 텍스트 인덱스

    private void Start()
    {
        textMesh = GetComponent<Text>();
        fullText = textMesh.text;
        textMesh.text = currentText; // 초기에는 아무 글자도 표시하지 않음
        StartCoroutine(ShowText());
    }

    private IEnumerator ShowText()
    {
        while (index < fullText.Length)
        {
            currentText = fullText.Substring(0, index + 1);
            textMesh.text = currentText;
            index++;
            yield return new WaitForSeconds(typingSpeed);
        }

        // Invoke("SpeedTyping", 3f);
    }

    // void SpeedTyping()
    // {
    //     this.gameObject.SetActive(false);
    // }
}

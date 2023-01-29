using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MsgManagement : MonoBehaviour
{
    public Text recognizeText;
    public string[] keywords;
    private bool isRecognize = false;
    private AipController aipController;

    void Start()
    {
        aipController = GameObject.Find("AipManager").GetComponent<AipController>();
    }

    void Update()
    {
        if(aipController.isSetText)
        {
            TextRecognition();
            aipController.isSetText = false;
        }
    }

    void TextRecognition()
    {
        for(int i = 0; i < keywords.Length; i++)
        {
            if(keywords[i] != null)
            {
                if(recognizeText.text.ToString().Contains(keywords[i]))
                {
                    EyesControl(i);
                    isRecognize = true;
                }
            }
        }

        if(!isRecognize)
        {
            Debug.Log("未识别到关键词");
            isRecognize = false;
        }
    }

    void EyesControl(int iNum)
    {
        switch(iNum)
        {
            case 0:
                //在此处编写你的操作代码
                
                Debug.Log("识别到关键词：" + keywords[iNum]);
                break;
            case 1:
                //在此处编写你的操作代码
                
                Debug.Log("识别到关键词：" + keywords[iNum]);
                break;
            case 2:
                //在此处编写你的操作代码
                
                Debug.Log("识别到关键词：" + keywords[iNum]);
                break;
            default:
                Debug.Log("该关键词尚未添加动作");
                break;
        }
    }
}

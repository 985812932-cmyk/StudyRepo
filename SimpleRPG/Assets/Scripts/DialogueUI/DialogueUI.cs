using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DialogueUI : MonoBehaviour
{
    public static DialogueUI Instance { get; private set; }

    public List<string> ContentList;
    private TextMeshProUGUI nameText;
    private TextMeshProUGUI ContentText;
    private Button continueButton;
    private int contentIndex = 0;

    public void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void Start()
    {
        nameText = transform.Find("NameTextBG/NameText").GetComponent<TextMeshProUGUI>();
        ContentText = transform.Find("ContentText").GetComponent<TextMeshProUGUI>();
        continueButton = transform.Find("ContinueButton").GetComponent<Button>();
        continueButton.onClick.AddListener(OnContinueButtonClick);
        Hide();
    }
    public void Show()
    {
        gameObject.SetActive(true);
    }

    public void Show(string name , string[] content)
    {
        nameText.text = name;
        ContentList = new List<string>(content);
        ContentText.text = ContentList[0];
        gameObject.SetActive(true);
    }

    public void Hide()
    {
        gameObject.SetActive(false);
    }

    public void OnContinueButtonClick()
    {
        contentIndex++;
        if (contentIndex < ContentList.Count)
        {
            ContentText.text = ContentList[contentIndex];
        }
        else
        {
            Hide();
            contentIndex = 0;
        }
    }
}

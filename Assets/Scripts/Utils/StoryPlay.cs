using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoryPlay : MonoBehaviour
{
    public GameObject storyPanel;
    public GameObject logPanel;
    public Text logText;
    public Image character, background;
    public Sprite defaultBackGround;
    public Text textBox, nameBox;
    public Button[] responses;
    public Text[] answers;
    int choice;
    int i, length;
    bool isDragging, haveToChoose, isInLogMode, isClickingUI, textIsGoing;
    private Vector3 mouseDownPos1, mouseDownPos2;
    Storyscene scene;
    float textDelay = 0.015f;

    private void Start() {
        storyPanel.SetActive(false);
        haveToChoose = false;
    }

    public void loadStory(string storyName) {
        Debug.Log(storyName);
        storyPanel.SetActive(true);
        scene = (Storyscene)Resources.Load("Stories/" + storyName);
        length = scene.story.Length;
        i = 0;
        choice = 0;
        haveToChoose = false;
        updateStory();
    }

    public void skipStory()
    {
        unloadStory();
        isClickingUI = true;
    }

    public void openLog()
    {
        isInLogMode = true;
        logPanel.GetComponent<ClickAndMove>().Going_Up();
    }

    public void closeLog()
    {
        isInLogMode = false;
        logPanel.GetComponent<ClickAndMove>().Going_Down();
        isClickingUI = true;
    }

    public void setNewTextDelay(float num)
    {
        textDelay = num;
    }

    void record(int type, string name, string sentence)
    {
        switch (type)
        {
            case 1: //人说的话
                logText.text = logText.text + name + ": " + "「" + sentence + "」\n";
                break;
            case 2: //旁白
                logText.text = logText.text + sentence + "\n";
                break;
            case 3: //你的选择
                logText.text = logText.text + "【" + sentence + "】\n";
                break;
            default:
                break;
        }
        
    }

    void unloadStory()
    {
        logText.text = " ";
        scene = null;
        length = 0;
        i = 0;
        choice = 0;
        storyPanel.SetActive(false);
    }

    void updateStory() {
        if (scene == null)
        {
            return;
        }
        if (scene.story[i].isChoice) {
            haveToChoose = true;
        }
        updateButton();
        if (choice != 0 && scene.story[i].branchNum == 0) {
            choice = 0;
        }
        if (choice != scene.story[i].branchNum) {
            i++;
            updateStory();
        } else {
            if (scene.story[i].background == null)
            {
                background.sprite = defaultBackGround;
            } else
            {
                background.sprite = scene.story[i].background;
            }
            if (scene.story[i].character == null)
            {
                character.color = new Color(1f, 1f, 1f, 0f);
            } else
            {
                character.color = new Color(1f, 1f, 1f, 1f);
                character.sprite = scene.story[i].character;
            }
            if (string.IsNullOrEmpty(scene.story[i].name))
            {
                nameBox.text = " ";
                record(2, " ", scene.story[i].words);
            } else
            {
                nameBox.text = scene.story[i].name;
                record(1, scene.story[i].name, scene.story[i].words);
            }
            StartCoroutine(showText(scene.story[i].words, textBox));
            i++;
        }
    }

    public void respondWith(int num)
    {
        isClickingUI = true;
        choice = num;
        haveToChoose = false;
        record(3, " ", answers[num - 1].text);
        updateStory();
    }

    void updateButton()
    {
        if (scene != null)
        {
            for (int j = 0; j < 3; j++)
            {
                if (string.IsNullOrEmpty(scene.story[i].response[j]))
                {
                    responses[j].gameObject.SetActive(false);
                }
                else
                {
                    responses[j].gameObject.SetActive(true);
                    answers[j].text = scene.story[i].response[j];
                }
            }
        }
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            isDragging = false;
            mouseDownPos1 = Input.mousePosition;
        }
        if (Input.GetMouseButton(0))
        {
            if (Vector3.Distance(mouseDownPos1, Input.mousePosition) > 10f)
            {
                isDragging = true;
            }
        }
        if (Input.GetMouseButtonUp(0)) {
            if (!isDragging && !haveToChoose && !isInLogMode && !isClickingUI && !textIsGoing)
            {
                if (i >= length)
                {
                    unloadStory();
                }
                updateStory();
            }
            if (isClickingUI)
            {
                isClickingUI = false;
            }
           
        }
    }

    IEnumerator showText(string fullText, Text output)
    {
        string currentText;
        textIsGoing = true;
        for (int k = 0; k <= fullText.Length; k++)
        {
            currentText = fullText.Substring(0, k);
            output.text = currentText;
            yield return new WaitForSeconds(textDelay);
        }
        textIsGoing = false;
    }
}

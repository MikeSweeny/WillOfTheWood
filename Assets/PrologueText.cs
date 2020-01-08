//FILE          :   UReturnToMenu.cs
//PROJECT       :   Will of the Wood
//PROGRAMMER    :   Michael Sweeny
//FIRST VERSION :   01/07/20
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

//NAME : PrologueText
//PURPOSE : Slowly prints text to the screen for the prologue "loadscreen"
public class PrologueText : MonoBehaviour
{
    private Text prologueTextComponent, skipPromptTextComponent, prologueTitleTextComponent, continueTextComponent;
    private Color prologueTextColor, skipPromptTextColor, prologueTitleTextColor, continueTextColor;
    private int textLength, currentChar;
    private bool textDone;
    private float textStartDelay, textTimerCurrent, textTimerPrevious, textTimerRandomDelta, textMinDelta, textMaxDelta, textEndTime, timeBeforeTextFade;
    private const string PROLOGUE_TEXT = 
        "The Forest is old. Older now than seems even possible. " +
        "Older than the memories of men have will to recall.          " +
        "\n\nBefore the coming of the vast seas, when the mountains " +
        "were yet still young, the timberlands there stood, " +
        "weary with age. The tall black sentinel " +
        "trees have stood vigil and witnessed the coming of " +
        "kings and the passing of ages untold, and it has " +
        "permitted neither the footsteps of men nor the swing " +
        "of their foul axes. The ways of the old world are " +
        "strong here, and it is those lordly ones who yet " +
        "dwell upon their withered thrones who kept it. " +
        "These true keepers of the wood, tall with skin aglow " +
        "like moonlight, they wander their lands as fleet as " +
        "wolf or hare. They smile and laugh and are glad, but " +
        "are terrible as the sweeping of hoarfrost upon the " +
        "morning rose. The elf kings of old make their misty " +
        "homes among these hollow woods, crowned by the roots " +
        "of elder trees and awash in the blood of those that " +
        "would trespass their Ancient Halls. " + 
        "\n\nArissa, the traveller, has come to the threshold of " +
        "these lands, to Thorngard, the last friendly home to " +
        "men south of this aged realm. Named for its defiance " +
        "of the woodland kings and their dark wills, Thorngard " +
        "has earned the ire of the elves who now amass to storm " +
        "the town. Though Thorngard’s people know little of the " +
        "elder folk they remain resolute, intent on keeping their " +
        "homes and ridding their land of these elf-folk. For " +
        "such times hold the promise of gold, ancient treasure and " +
        "knowledge of powers beyond the ken of mortal understanding...";

    // Start is called before the first frame update
    void Start()
    {
        prologueTextComponent = GetComponent<Text>();
        prologueTitleTextComponent = gameObject.transform.GetChild(0).gameObject.GetComponent<Text>();
        skipPromptTextComponent = gameObject.transform.GetChild(1).gameObject.GetComponent<Text>();
        continueTextComponent = gameObject.transform.GetChild(2).gameObject.GetComponent<Text>();
        prologueTextColor = prologueTextComponent.color;
        prologueTitleTextColor = prologueTitleTextComponent.color;
        skipPromptTextColor = skipPromptTextComponent.color;
        continueTextColor = continueTextComponent.color;

        textStartDelay = 1;
        textTimerCurrent = 0;
        textTimerPrevious = textStartDelay;
        currentChar = 0;
        textMinDelta = 0.02f;
        textMaxDelta = 0.1f;
        timeBeforeTextFade = 3f;
        textLength = PROLOGUE_TEXT.Length;
        RandomizeDelta(textMinDelta, textMaxDelta);
    }

    // Update is called every frame, independant of game speed
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            currentChar = PROLOGUE_TEXT.Length;
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.UnloadSceneAsync("IntroCutScene");
        }
    }

    // FixedUpdate is called once per ms
    void FixedUpdate()
    {
        IncrementTimer();
        // This section handles if the text is finished writing out, fades out the prologue text and skip text, then fades in the title
        if (textDone)
        {
            if (textTimerCurrent >= (textTimerPrevious + timeBeforeTextFade))
            {
                prologueTextColor.a -= 0.2f;
                prologueTextComponent.color = prologueTextColor;
                skipPromptTextColor.a -= 0.2f;
                skipPromptTextComponent.color = skipPromptTextColor;
            }
            if (textTimerCurrent >= (textTimerPrevious + (timeBeforeTextFade * 1.5)))
            {
                prologueTitleTextColor.a += 0.002f;
                prologueTitleTextComponent.color = prologueTitleTextColor;
                continueTextColor.a += 0.002f;
                continueTextComponent.color = continueTextColor;
                if (Input.anyKey)
                {
                    SceneManager.UnloadSceneAsync("IntroCutScene");
                }
            }
            return;
        }
        // This section deals with randomized typing out of hte prologue, and handles when the text is finished typing
        if (textTimerCurrent > textStartDelay)
        {
            if (textTimerCurrent >= textTimerPrevious + textTimerRandomDelta)
            {
                string currentPrintOut = PROLOGUE_TEXT.Substring(0, currentChar);
                prologueTextComponent.text = currentPrintOut;
                currentChar++;
                textTimerPrevious = textTimerCurrent;
                RandomizeDelta(textMinDelta, textMaxDelta);
                if (currentChar >= 50)
                {
                    skipPromptTextColor.a += 0.02f;
                    skipPromptTextComponent.color = skipPromptTextColor;
                }
                if (currentChar >= PROLOGUE_TEXT.Length)
                {
                    textEndTime = textTimerCurrent;
                    textDone = true;
                }
            }
        }
    }

    //Function : IncrementTimer
    //DESCRIPTION : Increments our timer using Time.deltaTime
    //PARAMETERS :  none
    //RETURNS : none
    private float IncrementTimer()
    {
        textTimerCurrent += Time.deltaTime;
        return textTimerCurrent;
    }

    //Function : RandomDelta
    //DESCRIPTION : Makes a random time in a range
    //PARAMETERS :  Min float and max float for the range
    //RETURNS : The random float between the range provided
    private void RandomizeDelta(float min, float max)
    {
        textTimerRandomDelta = Random.Range(min, max);
    }
}

//FILE          :   UReturnToMenu.cs
//PROJECT       :   Will of the Wood
//PROGRAMMER    :   Michael Sweeny
//FIRST VERSION :   01/07/20
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//NAME : PrologueText
//PURPOSE : Slowly prints text to the screen for the prologue "loadscreen"
public class PrologueText : MonoBehaviour
{
    private Text prologueTextComponent;
    private int textLength, currentChar;
    private float textStartDelay, textTimerCurrent, textTimerPrevious, textTimerRandomDelta, textMinDelta, textMaxDelta;
    private const string PROLOGUE_TEXT = 
        "The Forest is old, older now than it seems. " +
        "Older than the memories of men have will to recall.  " +
        "Before the coming of the vast seas, when the mountains " +
        "were yet still young, the timber lands there stood, " +
        "even then weary with age. Its tall black sentinel " +
        "trees have stood vigil and witnessed the coming of " +
        "kings and the passing of ages untold, and it has " +
        "permitted neither the footsteps men or the swing " +
        "of their foul axes. The ways of the old world are " +
        "strong here, and it is those lordly ones who yet " +
        "dwell upon their withered thrones who have kept it. " +
        "These true keepers of the wood, tall with skin aglow " +
        "like moonlight, they wander their lands as fleet as " +
        "wolf or hare. They smile and laugh and are glad, and " +
        "are terrible as the sweeping of hoarfrost upon the " +
        "morning rose. The elf kings of old make their misty " +
        "homes among these hollow woods, crowned by the roots " +
        "of elder trees and awash in the blood of those that " +
        "would trespass their Ancient Halls. " + 
        "\nArissa, the traveller, has come to the threshold of " +
        "these lands, to Thorngard, the last friendly home to " +
        "men south of this aged realm. Named for its defiance " +
        "of the woodland kings, and their dark wills, Thorngard " +
        "has earned the ire of the elves who now mass to storm " +
        "the town.Though Thorngard’s people know little of the " +
        "elder folk they remain resolute, intent on keeping their " +
        "homes and riding their land of these elf folk.Lands in " +
        "such times hold the promise of gold, ancient treasure and " +
        "knowledge of powers beyond the ken of mortal understanding.";

    // Start is called before the first frame update
    void Start()
    {
        prologueTextComponent = GetComponent<Text>();
        textStartDelay = 1;
        textTimerCurrent = 0;
        textTimerPrevious = 0;
        currentChar = 0;
        textLength = PROLOGUE_TEXT.Length;
        RandomizeDelta(textMinDelta, textMaxDelta);
    }

    // Update is called once per frame
    void Update()
    {
        IncrementTimer(textTimerCurrent);
        if (textTimerCurrent > textStartDelay)
        {
            if (textTimerCurrent >= textTimerPrevious + textStartDelay + textTimerRandomDelta)
            {
                string currentPrintOut = PROLOGUE_TEXT.Substring(0, currentChar);
                prologueTextComponent.text = currentPrintOut;
                currentChar++;
                RandomizeDelta(textMinDelta, textMaxDelta);
            }
        }
    }

    //Function : IncrementTimer
    //DESCRIPTION : Increments any timer using Time.deltaTime
    //PARAMETERS :  Takes the float representing the counter of a timer
    //RETURNS : The modified counter as float
    private float IncrementTimer(float timer)
    {
        timer += Time.deltaTime;
        return timer;
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

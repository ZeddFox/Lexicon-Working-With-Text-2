#region Exercise 1
using System.IO;

string mainText = "Nick sat against the wall of the church where they had dragged him to be clear of machine gun fire in the street. Both legs stuck out awkwardly. He had been hit in the spine. His face was sweaty and dirty. The sun shone on his face. The day was very hot. Rinaldi, big backed, his equipment sprawling, lay face downward against the wall. Nick looked straight ahead brilliantly. The pink wall of the house opposite had fallen out from the roof, and an iron bedstead hung twisted toward the street. Two Austrian dead lay in the rubble in the shade of the house. Up the street were other dead. Things were getting forward in the town. It was going well. Stretcher bearers would be along any time now. Nick turned his head carefully and looked down at Rinaldi. “Senta Rinaldi. Senta. You and me we’ve made a separate peace.” Rinaldi lay still in the sun breathing with difficulty. “Not patriots.” Nick turned his head carefully away smiling sweatily. Rinaldi was a disappointing audience. While the bombardment was knocking the trench to pieces at Fossalta, he lay very flat and sweated and prayed oh jesus christ get me out of here. Dear jesus please get me out. Christ please please please christ. If you’ll only keep me from getting killed I’ll do anything you say. I believe in you and I’ll tell everyone in the world that you are the only thing that matters. Please please dear jesus. The shelling moved further up the line. We went to work on the trench and in the morning the sun came up and the day was hot and muggy and cheerful and quiet. The next night back at Mestre he did not tell the girl he went upstairs with at the Villa Rossa about Jesus. And he never told anybody.";

string[] ArrayBySentence(string inputString)
{

    char[] textCharArray = inputString.ToCharArray();

    int periodAmount = 0;

    foreach (char c in textCharArray)
    {
        if (c == '.')
        {
            periodAmount += 1;
        }
    }

    string[] stringOut = new string[periodAmount];

    string currentSentence = "";

    List<string> stringList = new List<string>();

    for (int i = 0; i < textCharArray.GetLength(0); i++)
    {
        char c = textCharArray[i];

        if (c == '.')
        {
            currentSentence += c;
            stringList.Add(currentSentence);
            currentSentence = "";
        }
        else
        {
            currentSentence += c;
        }
    }

    for (int i = 0; i < stringList.Count; i++)
    {
        stringOut[i] = stringList[i];
    }

    return stringOut;
}

string[] Paragraphify(string[] inputStringArray, int paragraphMaxLength)
{

    int currentLength = 0;
    int currentParagraphNum = 0;
    string currentParagraph = "";

    for (int i = 0; i < inputStringArray.GetLength(0); i++)
    {
        currentLength += inputStringArray[i].Length;
    }

    int maxParagraphs = currentLength / paragraphMaxLength;

    currentLength = 0;

    string[] stringOut = new string[maxParagraphs];

    for (int i = 0; i < inputStringArray.GetLength(0); i++)
    {
        currentParagraph += inputStringArray[i];

        if (i < inputStringArray.GetLength(0) - 1)
        {
            if (currentParagraph.Length + inputStringArray[i + 1].Length > paragraphMaxLength)
            {
                if (currentParagraph.StartsWith(" "))
                {
                    currentParagraph = currentParagraph.Substring(1);
                }
                stringOut[currentParagraphNum] = currentParagraph;
                currentParagraphNum++;
                currentParagraph = "";
            }
        }
    }

    return stringOut;
}

string Sentencify(string[] inputParagraphArray)
{
    string stringOut = "";

    for (int i = 0; i < inputParagraphArray.GetLength(0); i++)
    {
        if (i == inputParagraphArray.GetLength(0) - 1)
        {
            stringOut += inputParagraphArray[i];
        }
        else
        {
            stringOut += inputParagraphArray[i] + "\n\n";
        }
    }

    return stringOut;
}

string textOut = Sentencify(Paragraphify(ArrayBySentence(mainText), 400));

Console.WriteLine(textOut);
Console.WriteLine();
#endregion
#region Exercise 2
string[] inputArray = ["Milk", "Yoghurt", "Cream", "Cottage Cheese"];

void ProductBackend(string[] inputStringArray)
{
    for (int i = 0; i < inputStringArray.GetLength(0); i++)
    {
        ProductPresentation(inputStringArray[i]);
    }
}

void ProductPresentation(string inputString)
{
    Console.WriteLine(inputString);
}

ProductBackend(inputArray);
#endregion

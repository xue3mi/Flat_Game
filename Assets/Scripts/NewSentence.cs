using UnityEngine;
using TMPro;

public class NewSentence : MonoBehaviour
{
    public TMP_Text myTMPText;
    public int nowText = 0;
    private int totalText = 7;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        myTMPText.text = "Welcome to Origami Box tutorial!!\r\nFirst we need a sqaure paper.\r\nLet's fold it twice.";
        nowText = 0;
    }

    // Update is called once per frame
    void Update()
    {
    
    }

    public void nowTextPlusOne()
    {
        nowText += 1;
    }

    public void nowTextMinusOne()
    {
        nowText -= 1;
    }

    public void changeToNewText()
    {
        if (nowText <=  totalText)
        {
            if(nowText < 0)
            {
                nowText = 0;
            }
            else if (nowText == 0)
            {
                myTMPText.text = "Welcome to Origami Box tutorial!!\r\nFirst we need a sqaure paper.\r\nLet's fold it twice.";
            }
            else if (nowText == 1)
            {
                myTMPText.text = "Now rotate the paper,\r\nand fold the 4 corners\r\ntoward the center point.";
            }
            else if(nowText == 2)
            {
                myTMPText.text = "Next, fold in half horizontally\r\nAnd another half.";
            }
            else if(nowText == 3)
            {
                myTMPText.text = "Unfold the left & right corners.\r\nThen fold the top & bottom edges\r\n down with the corners.";
            }
            else if (nowText == 4)
            {
                myTMPText.text = "Here comes the tricky part.\r\nWe will need these 2 edges \r\nthat we just made.";
            }
            else if (nowText == 5)
            {
                myTMPText.text = "See this Blue edge?\r\nFold inward so that red circle \r\naligns with the center point.";
            }
            else if (nowText == 6)
            {
                myTMPText.text = "Finally the last step!\r\nFold the protruding triangle inward.\r\nDo it again on the other side.";
            }
            else if (nowText == 7)
            {
                myTMPText.text = "Now you get a paper box!!";
            }
            else
            {
                myTMPText.text = "I dare you \r\nto judge \r\nmy paper box.";
            }
        }
        
    }
}

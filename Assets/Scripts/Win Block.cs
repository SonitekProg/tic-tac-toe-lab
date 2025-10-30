using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using TMPro;

namespace TicTacToe
{
    public class WinBlock : MonoBehaviour
    {
        [SerializeField] List<Button> buttons;
        [SerializeField] GameObject strikeOut;

        public bool isWin
        {
            get { return       buttons[0].transform.Find("Text (TMP)").GetComponent<TMP_Text>().text == buttons[1].transform.Find("Text (TMP)").GetComponent<TMP_Text>().text 
                            && buttons[0].transform.Find("Text (TMP)").GetComponent<TMP_Text>().text == buttons[2].transform.Find("Text (TMP)").GetComponent<TMP_Text>().text
                            && buttons[0].transform.Find("Text (TMP)").GetComponent<TMP_Text>().text != ""; }
        }

        public void dispStrikeOut(bool setActive)
        {
            strikeOut.SetActive(setActive);
        }

        public void CheckWin()
        {
            if (isWin)
            {
                // GameManager Stuff to end the game.
            }
        }
    }
}
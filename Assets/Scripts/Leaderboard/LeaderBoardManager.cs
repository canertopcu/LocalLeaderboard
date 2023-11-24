using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts
{
    public class LeaderBoardManager:MonoBehaviour
    {
      //  [SerializeField] private TextMeshPro leaderboardText;
        private ILeaderboardDataHandler dataHandler;
        private ILeaderboardUIHandler uiHandler;
        public TMP_InputField nameArea;
        public TMP_InputField scoreArea;
        public Button button;

        public void OnEnable()
        {
            button.onClick.AddListener(AddUIScore);
        }
        private void OnDisable()
        {
            button.onClick.RemoveListener(AddUIScore);
        }
        public void AddUIScore()
        {
            AddScore(nameArea.text, int.Parse(scoreArea.text));
        }
        private void Start()
        {

            dataHandler = new PlayerPrefsLeaderboardDataHandler();
          //  uiHandler = new TextLeaderboardUIHandler(leaderboardText);

            LoadLeaderboard();
           // UpdateLeaderboardUI();
        }

        public void AddScore(string playerName, int score)
        {
            PlayerData player = new PlayerData(playerName, score);
            dataHandler.AddScore(player);
            dataHandler.SortLeaderboard();
            SaveLeaderboard();
           // UpdateLeaderboardUI();
        }

        private void LoadLeaderboard()
        {
            dataHandler.LoadLeaderboard();
        }

        private void SaveLeaderboard()
        {
            dataHandler.SaveLeaderboard();
        }

        //private void UpdateLeaderboardUI()
        //{
        //    uiHandler.UpdateUI();
        //}
    }
}

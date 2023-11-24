using Newtonsoft.Json;
using System.Collections.Generic; 
using UnityEngine;
namespace Assets.Scripts
{
    internal class PlayerPrefsLeaderboardDataHandler : ILeaderboardDataHandler
    {
        public LeaderBoardData leaderboardData;

        public PlayerPrefsLeaderboardDataHandler()
        {
            leaderboardData = Resources.Load<LeaderBoardData>("Data/LeaderboardData");
        }

        public void AddScore(PlayerData player)
        {
            leaderboardData.AddScore(player);
        }

        public void SortLeaderboard()
        {
            leaderboardData.SortLeaderboard();
        }

        public void LoadLeaderboard()
        {
            string json = PlayerPrefs.GetString("Leaderboard", "");
            if (!string.IsNullOrEmpty(json))
            { 
                leaderboardData.Players = JsonConvert.DeserializeObject<List<PlayerData>>(json);
            }
        }

        public void SaveLeaderboard()
        {
            string json = JsonConvert.SerializeObject(leaderboardData.Players); 
            PlayerPrefs.SetString("Leaderboard", json);
            PlayerPrefs.Save();
        }
    }
}

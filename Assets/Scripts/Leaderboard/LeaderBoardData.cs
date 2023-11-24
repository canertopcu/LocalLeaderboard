using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts
{
    [CreateAssetMenu(fileName = "LeaderboardData", menuName = "LeaderboardData", order = 1)]
    public class LeaderBoardData:ScriptableObject
    {
        public List<PlayerData> Players = new List<PlayerData>();

        internal void AddScore(PlayerData player)
        {
            Players.Add(player);
        }

        internal void SortLeaderboard()
        {
            Players.Sort((a, b) => b.Score.CompareTo(a.Score));
        }
    }
}

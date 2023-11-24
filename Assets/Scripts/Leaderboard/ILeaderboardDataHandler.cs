namespace Assets.Scripts
{
    public interface ILeaderboardDataHandler
    {
        void AddScore(PlayerData player);
        void SortLeaderboard();
        void LoadLeaderboard();
        void SaveLeaderboard();
    }
}

namespace IceManager.Enum
{
    public enum iState { Wait, Play, Pause, Prev, Next };

    /// <summary>
    /// Status を文字列で返すための拡張クラス
    /// return パターンに対応した文字列
    /// </summary>
    public static class iTunesStatusExt
    {
        public static string ExtStatus(this iState value)
        {
            string[] values = { "Waiting...", "Playing...", "Pausing...", "Previsious...", "Next..." };
            return values[(int)value];
        }
    }
}

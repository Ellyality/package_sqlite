using UnityEngine;

namespace Elly.Sqlite
{
    [AddComponentMenu("Elly/Sqlite/Connection")]
    public class SqliteConnection : MonoBehaviour
    {
        [SerializeField] bool ConnectAtStart = true;
        [SerializeField] string Source = string.Empty;
        [SerializeField] SQLiteOpenFlags Flags = SQLiteOpenFlags.Create | SQLiteOpenFlags.ReadWrite;

        public SQLiteConnection conn { set; get; } = null;

        void Start()
        {
            if (ConnectAtStart)
            {
                conn = new SQLiteConnection(Source, Flags);
            }
        }

        private void OnDestroy()
        {
            conn.Close();
        }
    }
}

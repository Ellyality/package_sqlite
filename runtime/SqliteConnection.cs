using UnityEngine;

namespace Elly.Sqlite
{
    public class SqliteConnection : MonoBehaviour
    {
        [SerializeField] bool ConnectAtStart = true;
        [SerializeField] string Source = string.Empty;
        [SerializeField] SQLiteOpenFlags Flags;

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

using System.Xml.Linq;

namespace mini_bot_api.Dao
{
    public abstract class BaseDao
    {
        public static string GetSqlCommand(string FileName, string CommandName)
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ConstSql", $"{FileName}.xml");
            XDocument xdoc = XDocument.Load(path);

            var commandResult = (from lv1 in xdoc.Descendants(CommandName)
                select lv1.Value.Trim());
            if (!commandResult.Any())
            {
                throw new ArgumentOutOfRangeException(CommandName);

            }
            if (commandResult.Count() > 1)
            {
                throw new DuplicateWaitObjectException(CommandName);
            }
            return commandResult.SingleOrDefault()??string.Empty;
        }
    }
}

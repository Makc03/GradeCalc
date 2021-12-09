using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Data.SQLite;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Configuration;

namespace gradingcalc
{
    public class SqliteDataAccess
    {
        // gets inputs and sends to database
        public static List<PersonModel> LoadPeople()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<PersonModel>("select * from user", new DynamicParameters());
                return output.ToList();
            }
        }

        // saves 
        public static void SavePerson(PersonModel user)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into user (Subject, Points_Scored, Total_Possible, Total, Rounded) values (@Subject, @Achieved, @bTotal, @rTotal, @isRound)", user);
            }
        }
        

        // loads connectionstring 
        private static string LoadConnectionString(string id = "Default")
        { 
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}

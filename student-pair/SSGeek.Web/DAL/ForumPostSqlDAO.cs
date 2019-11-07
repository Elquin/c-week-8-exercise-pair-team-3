using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using SSGeek.Web.Models;

namespace SSGeek.Web.DAL
{
    public class ForumPostSqlDAO : IForumPostDAO
    {
        public IList<ForumPost> GetAllPosts()
        {
            IList<ForumPost> allPosts = new List<ForumPost>();
            string postSql = @"SELECT * FROM forum_post ORDER BY post_date DESC";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(postSql, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    allPosts.Add(MapRowToObject(reader));
                }
            }
            return allPosts;
        }

        public bool SaveNewPost(ForumPost post)
        {
            try
            {
                IList<ForumPost> allPosts = new List<ForumPost>();
                string postSql = @"INSERT INTO forum_post (username, subject, message, post_date) VALUES (@tn, @ts, @tm, GetDate())";
                

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(postSql, conn);
                    cmd.Parameters.AddWithValue("@tn", post.UserName);
                    cmd.Parameters.AddWithValue("@ts", post.Subject);
                    cmd.Parameters.AddWithValue("@tm", post.Message);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        allPosts.Add(MapRowToObject(reader));
                    }
                }
                return true;
            }
            catch(SqlException)
            {
                return false;
            }

            
        }

        private readonly string connectionString;

        public ForumPostSqlDAO(string connectionString)
        {
            this.connectionString = connectionString;
        }

        private ForumPost MapRowToObject(SqlDataReader reader)
        {
            return new ForumPost()
            {
                UserName = Convert.ToString(reader["username"]),
                Subject = Convert.ToString(reader["subject"]),
                Message = Convert.ToString(reader["message"]),
                PostDate = Convert.ToDateTime(reader["post_date"]),
            };
        }

    }
}

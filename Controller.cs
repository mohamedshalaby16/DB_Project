using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Xml.Linq;

namespace DBapplication
{
    public class Controller
    {
        DBManager dbMan;
        public Controller()
        {
            dbMan = new DBManager();
        }


        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }

        public int InsertArtist(int id, string fname, string lname, string password, string email, string nationality)
        {
            string query = $"INSERT INTO Artists VALUES({id},'{fname}','{lname}','{password}','{email}','{nationality}')";
            return dbMan.ExecuteNonQuery(query);
        }
        public int InsertUser(int id, string pass, string name, string email)
        {
            string query = $"INSERT INTO Users VALUES ({id},'{pass}','{name}','{email}')";
            return dbMan.ExecuteNonQuery(query);

        }
        public int InsertGallery(int id, string pass, string name, string location, string contact)
        {
            string query = $"INSERT INTO Galleries VALUES({id},'{pass}','{name}','{location}','{contact}')";
            return dbMan.ExecuteNonQuery(query);

        }
        public int AddArtwork(int artworkid, string title, string dimensions, string date, string description, int artistid)
        {
            string query = $"INSERT INTO Artworks Values ({artworkid},'{title}','{dimensions}','{date}','{description}',{artistid})";
            return dbMan.ExecuteNonQuery(query);
        }
    }
}

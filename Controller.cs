using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Xml.Linq;
using DB_Project;
using System.Runtime.InteropServices.ComTypes;

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
        public DataTable ShowArtworks(int artistid)
        {
            string query = $"SELECT   Artworks.ArtworkID,  Artworks.Title,  Artworks.Dimensions,  Artworks.CreationDate,   Artworks.Description FROM     Artworks INNER JOIN   Artists ON Artworks.ArtistID = Artists.ArtistID WHERE    Artists.ArtistID = {artistid};";
            return dbMan.ExecuteReader(query);
        }
        public int ChangeArtistPass(string newpass,int artistid)
        {
            string query = $"UPDATE Artists SET Password = '{newpass}'  WHERE ArtistID = {artistid};";
            return dbMan.ExecuteNonQuery(query);
        }
        public int ChangeGalleryPass(string newpass, int artistid)
        {
            string query = $"UPDATE Artists SET Password = '{newpass}'  WHERE ArtistID = {artistid};";
            return dbMan.ExecuteNonQuery(query);
        }
        public int AddExhibition(int exhibitionid, string name,string sdate, string edate,int galleryid,int artworkid)
        {
            string query = $"  INSERT INTO Exhibitions  VALUES({exhibitionid}, '{name}', '{sdate}', '{edate}', {galleryid}, {artworkid})";
            return dbMan.ExecuteNonQuery (query);

        }

        public DataTable ShowGallery()
        {
            string query = $"SELECT Name , GalleryID FROM Galleries ";
        return dbMan.ExecuteReader (query);
        }
        public DataTable ShowExhibition()
        {
            string query = $"SELECT   E.ExhibitionID , E.Name AS ExhibitionName , E.StartDate , E.EndDate, G.Name AS GalleryName,A.Title AS ArtworkTitle, A.Description AS ArtworkDescription FROM     Exhibitions E INNER JOIN   Galleries G ON E.GalleryID = G.GalleryID INNER JOIN     Artworks A ON E.ArtworkID = A.ArtworkID;";
        return dbMan.ExecuteReader(query) ;
        }

        public int UpdateArtistProfile(string email, string nat, int id)
        {
            string query = $"UPDATE Artists SET Email = '{email}', Nationality = '{nat}' WHERE ArtistID = {id};";
            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable ShowHighestBuyer(int artistid)
        {
            string query = $"SELECT \r\n    U.Name AS User_Name,\r\n    A.Title AS Artwork_Title,\r\n    O.Price AS Highest_Price\r\nFROM \r\n    Ownership O\r\nJOIN \r\n    Users U ON O.UserID = U.UserID\r\nJOIN \r\n    Artworks A ON O.ArtworkID = A.ArtworkID\r\nJOIN \r\n    Artists R ON A.ArtistID = R.ArtistID\r\nWHERE \r\n    R.ArtistID = {artistid}\r\n    AND O.Price = (\r\n        SELECT MAX(O2.Price)\r\n        FROM Ownership O2\r\n        JOIN Artworks A2 ON O2.ArtworkID = A2.ArtworkID\r\n        JOIN Artists R2 ON A2.ArtistID = R2.ArtistID\r\n        WHERE R2.ArtistID = {artistid}\r\n    );\r\n ";
            return dbMan.ExecuteReader (query);
        }
        

    }
}

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
using System.Collections;

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
        public int ChangeGalleryPass(string newpass, int galleryid)
        {
            string query = $"UPDATE Galleries SET Password = '{newpass}'  WHERE GalleryID = {galleryid};";
            return dbMan.ExecuteNonQuery(query);
        }
        public int ChangeUserPass(string newpass, int userid)
        {
            string query = $"UPDATE Users SET Password = '{newpass}'  WHERE UserID = {userid};";
            return dbMan.ExecuteNonQuery(query);
        }
        public int ChangeAdminPass(string newpass, int adminid)
        {
            string query = $"UPDATE Users SET Password = '{newpass}'  WHERE UserID = {adminid};";
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
        public DataTable ShowExhibition(int galleryid)
        {
            string query = $"SELECT   E.ExhibitionID , E.Name AS ExhibitionName , E.StartDate , E.EndDate, G.Name AS GalleryName,A.Title AS ArtworkTitle \r\nFROM     Exhibitions E, Artworks A, Galleries G\r\nWHERE    G.GalleryID={galleryid} AND E.ArtworkID=A.ArtworkID AND E.GalleryID=G.GalleryID ;";
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
        public int AddAuction( int galleryid, int artworkid, string name, int sellingprice)
        {
            string query = $"INSERT INTO AuctionHouse (GalleryID,ArtworkID,Name,SellingPrice) VALUES ({galleryid},{artworkid},'{name}',{sellingprice})";
            return dbMan.ExecuteNonQuery(query);
        }
        public DataTable GetHighestAuction(int galleryid)
        {
            string query = $"SELECT AuctionID, SellingPrice, ArtworkID FROM AuctionHouse WHERE GalleryID = '{galleryid}'  ORDER BY SellingPrice DESC";
            return dbMan.ExecuteReader(query);
        }
        public DataTable ViewOwnedArtworks(int id)
        {
            string query = $"SELECT R.ArtworkID,Title,Price FROM Ownership O,Artworks R WHERE R.ArtworkID=O.ArtworkID AND O.UserID= {id}";
            return dbMan.ExecuteReader(query);
        }

        
    
        public int RequestVerification(int id, int artworkid,string date, string status)
        {
            string query = $"INSERT INTO VerificationRequest (UserID,ArtworkID,RequestDate,VerificationStatus) VALUES( {id},{artworkid},'{date}', '{status}');";
            return dbMan.ExecuteNonQuery(query);

        }
        public DataTable getArtworks()
        {
            string query = $"SELECT Title,ArtworkID FROM Artworks";
            return dbMan.ExecuteReader(query);
        }
        public int giveFeedback(int id, int artworkid, string comment, int rating)
        {
            string query = $"INSERT INTO Reviews (UserID,ArtworkID,Comment,Rating) VALUES ({id},{artworkid},'{comment}',{rating});";
            return dbMan.ExecuteNonQuery(query);
        }
        public DataTable getRequestStatus(int id,int artworkid)
        {
            string query = $"SELECT VerificationStatus FROM VerificationRequest WHERE UserID={id} AND ArtworkID={artworkid};";
            return dbMan.ExecuteReader(query);
        }
        public DataTable getArtworksofuser(int id)
        {
            string query = $"SELECT A.Title, A.ArtworkID FROM Artworks A INNER JOIN VerificationRequest V ON V.ArtworkID = A.ArtworkID  WHERE V.UserID = {id};";
            return dbMan.ExecuteReader(query);
        }

        public DataTable HighestRated(int galleryID)
        {
            string query = $"SELECT A.Title AS Artwork_Title, R.Rating FROM Reviews R , Artworks A , Galleries G , Exhibitions E WHERE R.ArtworkID = A.ArtworkID AND G.GalleryID={galleryID} AND E.ArtworkID = A.ArtworkID AND E.GalleryID = G.GalleryID ORDER BY R.Rating DESC;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable AvgSellingPrice(int id) 
        {
            string query = $"SELECT G.Name, AVG(A.SellingPrice) FROM AuctionHouse A, Galleries G WHERE A.GalleryID={id} AND A.GalleryID = G.GalleryID GROUP BY G.Name;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable PendingRequests()
        {
            string query = $"SELECT U.Name , U.UserID FROM Users U , VerificationRequest V WHERE V.UserID = U.UserID AND V.VerificationStatus ='Pending';";
            return dbMan.ExecuteReader(query);
        }

        public int UpdateRequestStatus(string st,int id)
        {
            string query = $"UPDATE VerificationRequest SET VerificationStatus='{st}' WHERE UserID = {id}; ";
            return dbMan.ExecuteNonQuery(query);
        }

        public int NumPending()
        {
            string query = $"SELECT COUNT(*) FROM VerificationRequest WHERE VerificationStatus='Pending';";
            return (int) dbMan.ExecuteScalar(query);
        }

        public int InsertAdmin(int id,string pass) 
        {
            string query = $"INSERT INTO Admin VALUES({id},'{pass}')";
            return dbMan.ExecuteNonQuery(query);
        }
        public int CheckAdminPass(int id, string pass)
        {
            string query = $"SELECT COUNT(*) FROM Admin WHERE AdminID={id} AND Password='{pass}'";
            return (int)dbMan.ExecuteScalar(query); 
        }
        public int CheckUserPass(int id, string pass)
        {
            string query = $"SELECT COUNT(*) FROM Users WHERE UserID={id} AND Password='{pass}'";
            return (int)dbMan.ExecuteScalar(query); 
        }
        public int CheckArtistPass(int id, string pass)
        {
            string query = $"SELECT COUNT(*) FROM Artists WHERE ArtistID={id} AND Password='{pass}'";
            return (int)dbMan.ExecuteScalar(query);
        }
        public int CheckGalleryPass(int id, string pass)
        {
            string query = $"SELECT COUNT(*) FROM Galleries WHERE GalleryID={id} AND Password='{pass}'";
            return (int)dbMan.ExecuteScalar(query);
        }
    }
}

using System.Timers;
using HotelManagement.Data;

namespace HotelManagement
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            System.Timers.Timer aTimer = new System.Timers.Timer(86400);  // every day
            aTimer.Elapsed += new ElapsedEventHandler(DoArchive);
            aTimer.Start();
            Application.Run(new HomePage());
        }

        private static void DoArchive(object source, ElapsedEventArgs e)
        {
            Console.WriteLine(" Chercher l'existence des données à archiver");
            Database database = new Database();
            DateTime date_archivage = DateTime.Today.AddMonths(-6);

            var res = database.Reservations.Where(x => x.DateDebut <= date_archivage).ToList();

            if (res != null)
            {


                foreach (var entity in res)
                {


                    //Archivage de la réservation
                    var row = new Reservation();
                    row.ChambreId = entity.ChambreId;
                    row.ClientId = entity.ClientId;
                    row.DateDebut = entity.DateDebut;
                    row.DateFin = entity.DateFin;
                    row.DatePayeArrhes = entity.DatePayeArrhes;
                    row.Arrhes = entity.Arrhes;


                    var clientobject = database.Clients.Find(entity.Id);
                    //database.ArchiveReservations.Add(row);
                    database.Reservations.Remove(entity);
                    database.SaveChanges();




                    //Archivage du client
                    if (clientobject != null)
                    {
                        var rowClient = new Client();
                        rowClient.Nom = clientobject.Nom;
                        rowClient.Prenom = clientobject.Prenom;
                        rowClient.Adresse = clientobject.Adresse;
                        rowClient.Ville = clientobject.Ville;
                        rowClient.CodePostal = clientobject.CodePostal;
                        rowClient.Pays = clientobject.Pays;
                        rowClient.Cin = clientobject.Cin;
                        rowClient.NumTel = clientobject.NumTel;
                        rowClient.Email = clientobject.Email;

                        //database.ArchiveClients.Add(rowClient);
                        database.Clients.Remove(clientobject);
                        database.SaveChanges();
                    }





                    Console.WriteLine("l'archivage a  été effectué");

                }
            }

        }
    }
}
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
            /*System.Timers.Timer aTimer = new System.Timers.Timer(86400);  // every day
            aTimer.Elapsed += new ElapsedEventHandler(DoArchive);
            aTimer.Start();*/
            Application.Run(new HomePage());
        }

        /*private static void DoArchive(object source, ElapsedEventArgs e)
        {
            Console.WriteLine(" Chercher l'existence des données à archiver");
            Database database = new Database();
            DateTime date_archivage = DateTime.Today.AddMonths(-6);

            var res = database.Reservations.Where(x => x.DateDebut <= date_archivage).ToList();

            if (res != null)
            {


                foreach (var entity in res)
                {
                    Archivage du prestation liée à cette réservation
                    var prestationObject = database.PrestationReservations.Where(x => x.ReservationId == entity.Id).ToList();

                    if (prestationObject != null)
                    {
                        foreach (var entity2 in prestationObject)
                        {
                            var rowPrestation = new prestation();
                            rowPrestation.reservationid = entity2.reservationid;
                            rowPrestation.date_consommation = entity2.date_consommation;
                            rowPrestation.prix_prestation = entity2.prix_prestation;
                            rowPrestation.description = entity2.description;
                            rowPrestation.type_prestation = entity2.type_prestation;


                            database.prestations.Add(rowPrestation);
                            database.prestations1.Remove(entity2);
                            database.SaveChanges();

                        }

                    }


                    Archivage de la réservation
                    var row = new reservation();
                    row.chambreid = entity.chambreid;
                    row.clientid = entity.clientid;
                    row.date_res = entity.date_res;
                    row.date_debut = entity.date_debut;
                    row.date_fin = entity.date_fin;
                    row.date_pay_arrhes = entity.date_pay_arrhes;
                    row.prix_res = entity.prix_res;
                    row.arrhes = entity.arrhes;


                    var clientobject = db.clients1.Find(entity.clientid);
                    database.reservations.Add(row);
                    database.reservations1.Remove(entity);
                    database.SaveChanges();




                    Archivage du client
                    if (clientobject != null)
                    {
                        var rowClient = new client();
                        rowClient.nom = clientobject.nom;
                        rowClient.prenom = clientobject.prenom;
                        rowClient.address = clientobject.address;
                        rowClient.ville = clientobject.ville;
                        rowClient.code_postale = clientobject.code_postale;
                        rowClient.pays = clientobject.pays;
                        rowClient.tel = clientobject.tel;
                        rowClient.email = clientobject.email;

                        database.clients.Add(rowClient);
                        database.clients1.Remove(clientobject);
                        database.SaveChanges();
                    }





                    Console.WriteLine("l'archivage a  été effectué");

                }
            }

        }*/
    }
}
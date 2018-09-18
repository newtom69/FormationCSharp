using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DecouverteMVCNet.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.DateHeure = DateTime.Now;

            ViewBag.erreurSQL=0;
            int nbDroides=0;
            //test SQL
            try
            {
                using (SqlConnection connection = new SqlConnection())
                {
                    connection.ConnectionString = Properties.Settings.Default.MaConnexion; 
                    connection.Open();
                    using (SqlCommand command = connection.CreateCommand())
                    {
                        command.CommandText = "SELECT count(Nom) as NbDroides FROM Droide";

                        object retourExecScalar = command.ExecuteScalar();
                        if (retourExecScalar != null)
                        {
                            nbDroides = (int) retourExecScalar;
                        }
                        else
                        {
                            nbDroides = -1;
                        }
                    }
                }
                ViewBag.nbDroides = nbDroides;
            }
            catch
            {
                ViewBag.erreurSQL = 1;
            }

            return View();

        }

        public ActionResult About()
                    {
                        ViewBag.Message = "Your application description page.";
                        return View();
                    }

                    public ActionResult Contact()
                    {
                        ViewBag.Message = "Your contact page.";
                        ViewBag.MessageTom = "popopopopopop";
                        return View();
                    }
                    public ActionResult Thomas()
                    {
                        ViewBag.Message = "Your Thomas page.";
                        return View();
                    }
                }
            }
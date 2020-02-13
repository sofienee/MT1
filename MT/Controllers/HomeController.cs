using MT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;

namespace MT.Controllers
{
    public class HomeController : Controller
    {
        public string DOCNUM { get; private set; }

        public ActionResult Index()
        {
            return View();
        }



        public ActionResult About()
        {

            MTEntities DB_MT = new MTEntities();
            MT_1Entities DB_MT1 = new MT_1Entities();

            var Document_List = DB_MT1.ZDW_DOCUMENT_VIEW.ToList();
            var Camion_List = DB_MT1.CAMION.ToList();
            var Tier_List = DB_MT1.TIERS.ToList();
            var Reglement_List = DB_MT1.REGLEMENT.ToList();

            //foreach (var doc in Document_List)
            //{
            //    DOCUMENT document = new DOCUMENT();
            //    try
            //    {
            //        //test sur les shamps
            //        if (DB_MT.DOCUMENT.Where(d => d.DOCNUM == doc.DOCNUM).Count() >= 1)
            //        {

            //            return Json(new { success = false, message = "DOCNUM EXIST" },
            //                JsonRequestBehavior.AllowGet);
            //        }
            //        else
            //        {
            //            /*save*/
            //            document.DOCNUM = doc.DOCNUM;
            //            document.DOMID = doc.DOMID;
            //            document.TYPDOCID = doc.TYPDOCID;
            //            document.OPID = doc.OPID;
            //            document.TRFID = doc.TRFID;
            //            document.ENTITYID = doc.ENTITYID;
            //            document.ENTITYTYPE = doc.ENTITYTYPE;
            //            document.TIRPAYEUR = doc.TIRPAYEUR;
            //            document.TIRFACTURE = doc.TIRFACTURE;
            //            document.ADRFID = doc.ADRFID;
            //            document.ADRLID = doc.ADRLID;
            //            document.DEPID = doc.DEPID;
            //            document.DOCDATE = doc.DOCDATE;
            //            document.RGMID = doc.RGMID;
            //            document.TVATID = doc.TVATID;
            //            document.INTERSITES = doc.INTERSITES;
            //            document.DEVID = doc.DEVID;
            //            document.DOCCOLISAGE = doc.DOCCOLISAGE;
            //            document.CAMID = doc.CAMID;
            //            document.VSTID = doc.VSTID;
            //            document.TRNID = doc.TRNID;
            //            document.DOCMNTHTBRUT = doc.DOCMNTHTBRUT;
            //            document.DOCMNTREML = doc.DOCMNTREML;
            //            document.DOCMNTG = doc.DOCMNTG;
            //            document.DOCMNTRETOUR = doc.DOCMNTRETOUR;
            //            document.DOCESCOMPTE = doc.DOCESCOMPTE;
            //            document.DOCMNTESCOMPTE = doc.DOCMNTESCOMPTE;
            //            document.DOCMNTREMP = doc.DOCMNTREMP;
            //            document.DLPU = doc.DLPU;
            //            document.DLPUISTTC = doc.DLPUISTTC;
            //            document.DLPUHTBRUT = doc.DLPUHTBRUT;
            //            document.DLPUTTC = doc.DLPUTTC;
            //            document.DLPUHTNET = doc.DLPUHTNET;
            //            document.DISTRIBUTEUR = doc.DISTRIBUTEUR.ToString();


            //            //save
            //            DB_MT.DOCUMENT.Add(document);
            //            DB_MT.SaveChanges();
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        throw ex;
            //    }


            //}


            foreach (var cam in Camion_List)
            {

                CAMION camion = new CAMION();
                try
                {
                    // test sur les shamps
                    if (DB_MT.CAMION.Where(d => d.CAMCODE == cam.CAMCODE).Count() >= 1)
                    {
                        return Json(new { success = false, message = "CAMCODE EXIST" },
                            JsonRequestBehavior.AllowGet);
                    }
                    else
                    {
                        camion.CAMID = cam.CAMID;
                        camion.CAMCODE = cam.CAMCODE;
                        camion.CAMINTITULE = cam.CAMINTITULE;
                        camion.DEPID = cam.DEPID;
                        camion.DEVICEID = cam.DEVICEID;
                        camion.CAMCHAUFFEURID = cam.CAMCHAUFFEURID;
                        camion.CAMVENDEURID = cam.CAMVENDEURID;
                        camion.DOSID = cam.DOSID;
                        camion.TIRCAM = cam.TIRCAM;
                        camion.CAMISACTIF = cam.CAMISACTIF;
                        camion.CAMMATRICULE = cam.CAMMATRICULE;
                        camion.CAMDISPO = cam.CAMDISPO;
                        camion.CAMDATEVIDANGE = cam.CAMDATEVIDANGE;
                        camion.CAMVOLUME = cam.CAMVOLUME;
                        camion.CAMPOIDSSUPP = cam.CAMPOIDSSUPP;
                        camion.CAMLASTMISSION = cam.CAMLASTMISSION;
                        camion.CAMMODELE = cam.CAMMODELE;
                        camion.CAMREFERENCE = cam.CAMREFERENCE;
                        camion.CAMVISITE = cam.CAMVISITE;
                        camion.CAMVIGNETTE = cam.CAMVIGNETTE;
                        camion.CAMNOTE = cam.CAMNOTE;
                        camion.NUMEROTATION_PREFIX = cam.NUMEROTATION_PREFIX;
                        camion.USERUPDATE = cam.USERUPDATE;
                        camion.USERCREATE = cam.USERCREATE;
                        camion.DATECREATE = cam.DATECREATE;
                        camion.DATEUPDATE = cam.DATEUPDATE;
                        camion.PLATEFORME = cam.PLATEFORME;
                        //   camion.DISTRIBUTEUR = cam.DISTRIBUTEUR.ToString();

                        DB_MT.CAMION.Add(camion);
                        DB_MT.SaveChanges();

                    }
                }
                catch (Exception e)
                {
                    throw e;
                }


            }

            //foreach (var tie in Tier_List)
            //{
            //    TIERS tiers = new TIERS();
            //    try
            //    {
            //        if (DB_MT.TIERS.Where(d => d.TIRCODE == tie.TIRCODE).Count() >= 1)
            //        {
            //            return Json(new { success = false, message = "TIRCODE EXIST" },
            //                JsonRequestBehavior.AllowGet);
            //        }
            //        else
            //        {
            //            tiers.DOSID = tie.DOSID;
            //            tiers.TIRCATID = tie.TIRCATID;
            //            tiers.TIRCATTIERSID = tie.TIRCATTIERSID;
            //            tiers.TIRTYPE = tie.TIRTYPE;
            //            tiers.TIRSITEINTERNE = tie.TIRSITEINTERNE;
            //            tiers.TIRCODE = tie.TIRCODE;
            //            tiers.TIRCODEERP = tie.TIRCODEERP;
            //            tiers.TIRSOCIETE = tie.TIRSOCIETE;
            //            tiers.TIRABREGE = tie.TIRABREGE;
            //            tiers.CPTCODE = tie.CPTCODE;
            //            tiers.COLID = tie.COLID;
            //            tiers.ADRFID = tie.ADRFID;
            //            tiers.ADRLID = tie.ADRLID;
            //            tiers.CONTACTID = tie.CONTACTID;
            //            tiers.TIRIDENTIFIANT = tie.TIRIDENTIFIANT;
            //            tiers.TIRCIN = tie.TIRCIN;
            //            tiers.TIRPATENTE = tie.TIRPATENTE;
            //            tiers.TIRACTIVITE = tie.TIRACTIVITE;
            //            tiers.DEVID = tie.DEVID;
            //            tiers.TRFID = tie.TRFID;
            //            tiers.TRFPID = tie.TRFPID;
            //            tiers.RGMID = tie.RGMID;
            //            tiers.TVATID = tie.TVATID;
            //            tiers.TIRISASSUJETTITPF = tie.TIRISASSUJETTITPF;
            //            tiers.TIRISASSUJETTITVA = tie.TIRISASSUJETTITVA;
            //            tiers.TIRISFACTURE = tie.TIRISFACTURE;
            //            tiers.TIRISACTIF = tie.TIRISACTIF;
            //            tiers.TIRTAUXREMISE = tie.TIRTAUXREMISE;
            //            tiers.TIRTAUXESCOMPTE = tie.TIRTAUXESCOMPTE;
            //            tiers.TIRPUREMISE = tie.TIRPUREMISE;
            //            tiers.TIRENCOURS = tie.TIRENCOURS;
            //            tiers.TIRNBFACT = tie.TIRNBFACT;
            //            tiers.STATENUMID1 = tie.STATENUMID1;
            //            tiers.STATENUMID2 = tie.STATENUMID2;
            //            tiers.STATENUMID3 = tie.STATENUMID3;
            //            tiers.STATENUMID4 = tie.STATENUMID4;
            //            tiers.STATENUMID5 = tie.STATENUMID5;
            //            tiers.STATENUMID6 = tie.STATENUMID6;
            //            tiers.TIRLASTVISITE = tie.TIRLASTVISITE;
            //            tiers.TIRRATE = tie.TIRRATE;
            //            tiers.TIRSOLDER = tie.TIRSOLDER;
            //            tiers.TIRSOLDEINI = tie.TIRSOLDEINI;
            //            tiers.TIRISCREDIT = tie.TIRISCREDIT;
            //            tiers.TIRSITEINTERNE = tie.TIRISINTERNE;
            //            tiers.TIRAGREMENT = tie.TIRAGREMENT;
            //            tiers.TIRDATEAGREMENT = tie.TIRDATEAGREMENT;
            //            tiers.TIRRISQUE = tie.TIRRISQUE;
            //            tiers.TIRPAYEUR = tie.TIRPAYEUR;
            //            tiers.TIRFACTURE = tie.TIRFACTURE;
            //            tiers.TIRNOTE = tie.TIRNOTE;
            //            tiers.USERCREATE = tie.USERCREATE;
            //            tiers.USERUPDATE = tie.USERUPDATE;
            //            tiers.DATECREATE = tie.DATECREATE;
            //            tiers.DATEUPDATE = tie.DATEUPDATE;
            //            tiers.TIRIDFROMMOBILE = tie.TIRIDFROMMOBILE;
            //            tiers.CREDITCONTENTIEUX = tie.CREDITCONTENTIEUX;
            //            tiers.CAMID = tie.CAMID;
            //            tiers.FLAG_SYNC_ERP = tie.FLAG_SYNC_ERP;
            //            tiers.TIRICE = tie.TIRICE;
            //            tiers.DISTRIBUTEUR = tie.DISTRIBUTEUR;



            //            DB_MT.TIERS.Add(tiers);
            //            DB_MT.SaveChanges();
            //        }
            //    }
            //    catch (Exception e)
            //    {
            //        throw e;
            //    }
            //}
            //foreach (var reg in Reglement_List)
            //{
            //    REGLEMENT reglement = new REGLEMENT();

            //    reglement.REGID = reg.REGID ;
            //    reglement.REGNUM = reg.REGNUM ;
            //    reglement.DOSID = reg.DOSID ;
            //    reglement.TRNID = reg.TRNID ;
            //    reglement.REGDATE = reg.REGDATE ;
            //    reglement.REGREF = reg.REGREF ;
            //    reglement.REGLIBELLE = reg.REGLIBELLE ;
            //    reglement.TIRID = reg.TIRID ;
            //    reglement.TIRPAYID = reg.TIRPAYID ;
            //    reglement.REGMONTANT = reg.REGMONTANT ;
            //    reglement.DEVID = reg.DEVID ;
            //    reglement.DEVCOURS = reg.DEVCOURS ;
            //    reglement.RGMID = reg.RGMID ;
            //    reglement.REGISIMPUTE = reg.REGISIMPUTE ;
            //    reglement.REGTYPE = reg.REGTYPE ;
            //    reglement.REGECHEANCE = reg.REGECHEANCE ;
            //    reglement.REGMONTANTIMPUTE = reg.REGMONTANTIMPUTE ;
            //    reglement.REGMONTANTECART = reg.REGMONTANTECART ;
            //    reglement.REGMONTANTSOLDE = reg.REGMONTANTSOLDE ;
            //    reglement.REGNOTE = reg.REGNOTE ;
            //    reglement.USERCREATE = reg.USERCREATE ;
            //    reglement.USERUPDATE = reg.USERUPDATE ;
            //    reglement.REGIDFROMMOBILE = reg.REGIDFROMMOBILE ;
            //    reglement.TTRNID = reg.TTRNID ;
            //    reglement.TIRCAM = reg.TIRCAM ;
            //    reglement.CHQNUMERO = reg.CHQNUMERO ;
            //    reglement.CHQDATE = reg.CHQDATE ;
            //    reglement.CHQBANQUE = reg.CHQBANQUE ;
            //    reglement.REGNAT = reg.REGNAT ;
            //    reglement.DISTRIBUTEUR = reg.DISTRIBUTEUR ;



            //    DB_MT.REGLEMENT.Add(reglement);
            //    DB_MT.SaveChanges();

            //}




            ViewBag.Message = "Your application description page.";


                return View();
            }
        
        
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using MyAirport.Entities;
using MyAirport.Data;
using System.Security.Permissions;
using System.Security.Principal;
using System.Threading;

namespace MyAirport.Service
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "Service1" à la fois dans le code et le fichier de configuration.
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall, IncludeExceptionDetailInFaults = true)]
    public class Service1 : IService1
    {
        public static int NbInstance = 0;

        public int NbAppel = 0;

        public Service1()
        {
            //WindowsPrincipal user = new WindowsPrincipal((WindowsIdentity)Thread.CurrentPrincipal.Identity);
            NbInstance++;
        }

        ~Service1()
        {
            NbInstance--;
        }

        public int TestFaultException(int v1, int v2)
        {

            int res = 0;
            try
            {
                res = v1 / v2;
            }
            catch (DivideByZeroException)
            {
                var p = new PersoFaultException();
                p.Message = String.Format("Impossible de diviser {0} par {1}",v1, v2);
                p.V1 = v1;
                p.V2 = v2;
                throw new FaultException<PersoFaultException>(p);
            }
            return res;
        }


        public VolDefinition DetailVol(int id)
        {
            VolDefinition res = null;

            if (Thread.CurrentPrincipal.IsInRole("CEBCDG1"))
            {
                res = MyAirport.Factory.ModelsFactory.Model.GetVol(id);
            }
            else
            {
                res = MyAirport.Factory.ModelsFactory.Model.GetVol(id);
                res.CIE = null;
            }
            string user = Thread.CurrentPrincipal.Identity.Name;
            this.NbAppel++;

            return res;
        }

        public List<VolDefinition> RechercherVolsDeLaCompagnie(string compagnie)
        {
            this.NbAppel++;
            VolCriteres c = new VolCriteres();
            c.Compagnies = new List<string>();
            c.Compagnies.Add(compagnie);
            return MyAirport.Factory.ModelsFactory.Model.GetVols(c);
        }

        public List<VolDefinition> RechercherVolsParDate(DateTime debut, DateTime fin)
        {
            this.NbAppel++;
            VolCriteres c = new VolCriteres();
            c.dateDebut = debut;
            c.dateFin = fin;
            return MyAirport.Factory.ModelsFactory.Model.GetVols(c);
        }

        public List<VolDefinition> RechercherVolsDuJour()
        {
            this.NbAppel++;
            VolCriteres c = new VolCriteres();
            return MyAirport.Factory.ModelsFactory.Model.GetVols(c);
        }

        public List<BagageDefinition> RechercherBagagesDuVol(int idVol)
        {
            this.NbAppel++;
            BagageCriteres b = new BagageCriteres();
            return MyAirport.Factory.ModelsFactory.Model.GetBagages(b);
        }

        public List<BagageDefinition> RechercherBagagesParDate(DateTime debut, DateTime fin)
        {
            this.NbAppel++;
            BagageCriteres b = new BagageCriteres();
            return MyAirport.Factory.ModelsFactory.Model.GetBagages(b);
        }

        public List<BagageDefinition> RechercherBagagesDuJour()
        {
            this.NbAppel++;
            BagageCriteres b = new BagageCriteres();
            return MyAirport.Factory.ModelsFactory.Model.GetBagages(b);
        }

        public BagageDefinition DetailBagage(int id)
        {
            this.NbAppel++;
            return MyAirport.Factory.ModelsFactory.Model.GetBagage(id);
        }
        [PrincipalPermission(SecurityAction.Demand, Role="CDG1")]
        public Parametres MesParamatres()
        {
            throw new NotImplementedException();
        }

        [PrincipalPermission(SecurityAction.Demand, Role = "CDG1")]
        public void UpdateMesParametres(Parametres parameters)
        {
            throw new NotImplementedException();
        }

        [PrincipalPermission(SecurityAction.Demand, Role = "CDG1")]
        public List<Historique> MonHistorique()
        {
            throw new NotImplementedException();
        }

        [PrincipalPermission(SecurityAction.Demand, Role = "CEB-CDG1")]
        public void CreateVol(VolDefinition newVol)
        {
        }
    }
    
}
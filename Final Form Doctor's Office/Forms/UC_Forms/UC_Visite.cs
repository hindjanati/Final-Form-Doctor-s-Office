using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Form_Doctor_s_Office.Forms.UC_Forms
{
    public partial class UC_Visite : UserControl
    {
        public UC_Visite()
        {
            InitializeComponent();
        }

        private void UC_Visite_Load(object sender, EventArgs e)
        {
            Classes.GG.charge();
            foreach (DataRow dr in Classes.GG.ds.Visite.Rows) // remplissage de la liste
            {
                int k = 0;
                foreach (DataRow drr in Classes.GG.ds.Ordonnance.Select("ID_visite='" + dr[0] + "'"))
                {
                    foreach(DataRow drrr in Classes.GG.ds.Medicament_Patient.Select("ID_ordonnance=" + drr[0]))
                    {
                        k++;
                        break;
                    }
                }
                if ((bool)dr[4] == false && k == 0)
                {
                    if (Convert.ToDateTime(dr[2]).Date == DateTime.Now.Date)
                    {
                        foreach (DataRow dr2 in Classes.GG.ds.Patient.Select("CIN_Patient='" + dr[1] + "'"))
                        {
                            Dgv_Visite_aujourdhui.Rows.Add(dr[0], dr2[1], dr2[2], (DateTime.Now.Year - Convert.ToDateTime(dr2[6]).Year));
                        }
                    }
                }
            }
        }
        void ajouterOrdonnance(int idVisite) // methode d'ajouter ordonnance 
        {
            DataRow ligne = Classes.GG.ds.Ordonnance.NewRow();
            ligne[1] = idVisite;
            Classes.GG.ds.Ordonnance.Rows.Add(ligne);
            Classes.GG.d_ordonnance.Update(Classes.GG.ds.Ordonnance);
        }
        private void dtp_Visite_ValueChanged(object sender, EventArgs e)
        {
            Dgv_Visite_aujourdhui.Rows.Clear();
            foreach (DataRow dr in Classes.GG.ds.Visite.Rows)
            {
                int k = 0;
                foreach (DataRow drr in Classes.GG.ds.Ordonnance.Select("ID_visite='" + dr[0] + "'"))
                {
                    foreach (DataRow drrr in Classes.GG.ds.Medicament_Patient.Select("ID_ordonnance=" + drr[0]))
                    {
                        k++;
                        break;
                    }
                }
                if ((bool)dr[4] == false && k == 0)
                {
                    if (Convert.ToDateTime(dr[2]).Date == dtp_Visite.Value.Date)
                    {
                        foreach (DataRow dr2 in Classes.GG.ds.Patient.Select("CIN_Patient='" + dr[1] + "'"))
                        {
                            Dgv_Visite_aujourdhui.Rows.Add(dr[0], dr2[1], dr2[2], (DateTime.Now.Year - Convert.ToDateTime(dr2[6]).Year));
                        }
                    }
                }
            }
        }
        private void bt_refresh_Click(object sender, EventArgs e)
        {
            dtp_Visite.Value = DateTime.Now;
            Dgv_Visite_aujourdhui.Rows.Clear();
            foreach (DataRow dr in Classes.GG.ds.Visite.Rows)
            {
                int k = 0;
                foreach (DataRow drr in Classes.GG.ds.Ordonnance.Select("ID_visite='" + dr[0] + "'"))
                {
                    foreach (DataRow drrr in Classes.GG.ds.Medicament_Patient.Select("ID_ordonnance=" + drr[0]))
                    {
                        k++;
                        break;
                    }
                }
                if ((bool)dr[4] == false && k == 0)
                {
                    if (Convert.ToDateTime(dr[2]).Date == DateTime.Now.Date)
                    {
                        foreach (DataRow dr2 in Classes.GG.ds.Patient.Select("CIN_Patient='" + dr[1] + "'"))
                        {
                            Dgv_Visite_aujourdhui.Rows.Add(dr[0], dr2[1], dr2[2], (DateTime.Now.Year - Convert.ToDateTime(dr2[6]).Year));
                        }
                    }
                }
            }
        }
        private void Dgv_Visite_aujourdhui_DoubleClick(object sender, EventArgs e)
        {
            int j = Dgv_Visite_aujourdhui.CurrentCell.RowIndex;
            Classes.GG.Visiteid = int.Parse(Dgv_Visite_aujourdhui.Rows[j].Cells[0].Value.ToString());
            ajouterOrdonnance(Classes.GG.Visiteid);
            Classes.GG.charge();
            OleDbDataAdapter d_ordonnance = new OleDbDataAdapter("select top 1 ID_ordonnance from Ordonnance ORDER BY ID_ordonnance desc", Classes.GG.cnx);
            d_ordonnance.Fill(Classes.GG.ds, "id_ordonnance");
            DataRow d = Classes.GG.ds.Tables["id_ordonnance"].Rows[0];
            Classes.GG.Ordonnanceid = int.Parse(d[0].ToString());
            Form_Ajouter_Ordonnance ajouter_Ordonnance = new Form_Ajouter_Ordonnance();
            ajouter_Ordonnance.Show();
        }
    }
}

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
    public partial class UC_RendezVous : UserControl
    {
        public UC_RendezVous()
        {
            InitializeComponent();
        }
        void remplirDGV() // remplissage de la liste
        {
            Dgv_rendezVous.Rows.Clear();
            foreach (DataRow dr in Classes.GG.ds.Visite.Rows)
            {
                if ((bool)dr[4] == true)
                {
                    if (Convert.ToDateTime(dr[2]).Date == DateTime.Now.Date)
                    {
                        foreach (DataRow dr2 in Classes.GG.ds.Patient.Select("CIN_Patient='" + dr[1] + "'"))
                        {

                            Dgv_rendezVous.Rows.Add(dr[0], dr2[1], dr2[2], (DateTime.Now.Year - Convert.ToDateTime(dr2[6]).Year), Convert.ToDateTime(dr[5]).ToShortTimeString());
                        }
                    }
                }

            }
        }
        private void UC_RendezVous_Load(object sender, EventArgs e)
        {
            Classes.GG.charge();
            remplirDGV();
        }
        private void tb_prix_KeyPress(object sender, KeyPressEventArgs e) // nombre seulement
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        void ajouterOrdonnance(int idVisite) // methode d'ajouter ordonnance 
        {
            DataRow ligne = Classes.GG.ds.Ordonnance.NewRow();
            ligne[1] = idVisite;
            Classes.GG.ds.Ordonnance.Rows.Add(ligne);
            Classes.GG.d_ordonnance.Update(Classes.GG.ds.Ordonnance);
        }
        private void btn_refresh_p_Click(object sender, EventArgs e) // button refresh
        {
            dtp_rendezVous.Value = DateTime.Now;
            remplirDGV();
        }
        private void Dgv_rendezVous_DoubleClick(object sender, EventArgs e)
        {
            panel_visite.Visible = true;
            int j = Dgv_rendezVous.CurrentCell.RowIndex;
            Classes.GG.Visiteid = int.Parse(Dgv_rendezVous.Rows[j].Cells[0].Value.ToString());
        }
        private void dtp_rendezVous_ValueChanged(object sender, EventArgs e)
        {
            Dgv_rendezVous.Rows.Clear();
            foreach (DataRow dr in Classes.GG.ds.Visite.Rows)
            {
                if ((bool)dr[4] == true)
                {
                    if (Convert.ToDateTime(dr[2]).Date == dtp_rendezVous.Value.Date)
                    {
                        foreach (DataRow dr2 in Classes.GG.ds.Patient.Select("CIN_Patient='" + dr[1] + "'"))
                        {
                            Dgv_rendezVous.Rows.Add(dr[0], dr2[1], dr2[2], (DateTime.Now.Year - Convert.ToDateTime(dr2[6]).Year), Convert.ToDateTime(dr[5]).ToShortTimeString());
                        }
                    }
                }
            }
        }

        private void btn_enregistrer_Click(object sender, EventArgs e)
        {
            if (tb_prix.Text == "")
            {
                MessageBox.Show("Merci de donnee le prix !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                foreach (DataRow dr in Classes.GG.ds.Visite.Select("ID_visite='" + Classes.GG.Visiteid + "'"))
                {
                    dr[3] = double.Parse(tb_prix.Text);
                    dr[4] = false;
                    MessageBox.Show("kk");
                }
                Classes.GG.d_visite.Update(Classes.GG.ds.Visite);
                MessageBox.Show("Félicitation visite est ajouté avec succès", "Opération effectuée avec succés", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ajouterOrdonnance(Classes.GG.Visiteid);
                Classes.GG.charge();
                OleDbDataAdapter d_ordonnance = new OleDbDataAdapter("select top 1 ID_ordonnance from Ordonnance ORDER BY ID_ordonnance desc", Classes.GG.cnx);
                d_ordonnance.Fill(Classes.GG.ds, "id_ordonnance");
                DataRow d = Classes.GG.ds.Tables["id_ordonnance"].Rows[0];
                Classes.GG.Ordonnanceid = int.Parse(d[0].ToString());
                Forms.Form_Ajouter_Ordonnance ao = new Form_Ajouter_Ordonnance();
                ao.Show();
                remplirDGV();
            }
        }
        private void btn_refresh_p_Click_1(object sender, EventArgs e)
        {
            
            dtp_rendezVous.Value = DateTime.Now;
            remplirDGV();
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace Proje_Hastane
{
    public partial class FrmBilgiDüzenle : Form
    {
        public FrmBilgiDüzenle()
        {
            InitializeComponent();
        }

        SqlBaglantsi bgl = new SqlBaglantsi();  

        public string TCno;
        private void FrmBilgiDüzenle_Load(object sender, EventArgs e)
        {
            mskTC.Text = TCno;

            // Bilgiler TextBox'lara aktarma işlemi.
            SqlCommand komut = new SqlCommand("Select * From Tbl_Hastalar where HastaTC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",mskTC.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                txtAd.Text = dr[1].ToString();  
                txtSoyad.Text = dr[2].ToString();
                mskTC.Text = dr[3].ToString();
                mskTelefon.Text = dr[4].ToString(); 
                txtSifre.Text = dr[5].ToString();
                cmbCinsiyet.Text = dr[6].ToString();    
            }
            bgl.baglanti().Close();
        }

        private void btnBilgiGüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("update Tbl_Hastalar set HastaAd=@p1,HastaSoyad=@p2,HastaTelefon=@p3,HastaSifre=@p4,HastaCinsiyet=@p5 where HastaTC=@p6", bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1", txtAd.Text);
            komut2.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komut2.Parameters.AddWithValue("@p3", mskTelefon.Text);
            komut2.Parameters.AddWithValue("@p4", txtSifre.Text);
            komut2.Parameters.AddWithValue("@p5", cmbCinsiyet.Text);
            komut2.Parameters.AddWithValue("@p6", mskTC.Text);  
            komut2.ExecuteNonQuery();

            bgl.baglanti().Close(); 
            MessageBox.Show("Bilgileriniz Başarıyla Güncelledi.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}

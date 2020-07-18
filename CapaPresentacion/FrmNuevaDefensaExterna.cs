using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmNuevaDefensaExterna : Form
    {
        #region constructor

        public FrmNuevaDefensaExterna()
        {
            InitializeComponent();
        }


        #endregion


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

     

        

        private void btnCancelarNuevaD_Click(object sender, EventArgs e)
        {
            this.Close();
        }




        #region Destructor

        ~FrmNuevaDefensaExterna()
        {

        }

        #endregion


    }
}

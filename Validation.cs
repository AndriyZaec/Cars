using System.Windows.Forms;

namespace Cars
{
    class Validation
    {
        public void Validete(KeyPressEventArgs e)
        {

            if (e.KeyChar != 8 && (e.KeyChar < 48 || e.KeyChar > 57))
            {
                e.Handled = true;
            }   
        }
    }
}

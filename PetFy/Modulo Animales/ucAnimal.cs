using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetFy
{
    public partial class ucAnimal : UserControl
    {
        public ucAnimal()
        {
            InitializeComponent();
        }

        private void pbAnimal_Paint(object sender, PaintEventArgs e)
        {
            // Podemos mejorar el aspecto del borde redondeado aplicando antialias
            // Graphics.SmoothingMode obtiene o establece la calidad de la representación del objeto Graphics
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            // Creamos un objeto de la clase GraphicsPath que representa una serie de líneas y curvas conectadas
            GraphicsPath curra = new GraphicsPath();
            // Manipulando las variables que se corresponden con los puntos x.y, ancho y alto de la figura podemos variar su aspecto
            int x = 0;
            int y = 0;
            int ancho = 0;
            int alto = 0;
            // Posiciones x.y del objeto curra (las del control PictureBox)
            x = pbAnimal.Left;
            y = pbAnimal.Top;
            // Anchura y altura del objeto curra, un poco menores que las del PictureBox para que se vea bien ajustado al control
            ancho = pbAnimal.Width - 24;
            alto = pbAnimal.Height - 24;
            // Usamos el método AddEllipse para agregar la forma de un círculo o elipse al trazado actual (el control PictureBox)
            curra.AddEllipse(new Rectangle(x, y, ancho, alto));
            // En el PictureBox creamos una región que se corresponde con la forma del objeto GraphicsPath (círculo)
            // y se dibuja en el PictureBox asignando el objeto curra a la región
            // Region de System.Drawing describe el interior de una forma gráfica formada por rectángulos y trazados
            Region reg = default(Region);
            reg = new Region(curra);
            pbAnimal.Region = reg;
            // Otra forma de realizarlo
            //pBox.Region = New Region(curra)
        }
    }
}

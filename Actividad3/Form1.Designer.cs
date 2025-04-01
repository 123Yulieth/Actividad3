namespace Actividad3
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblPosX;
        private System.Windows.Forms.Label lblPosY;
        private System.Windows.Forms.Label lblContador;
        private System.Windows.Forms.TextBox txtPosX;
        private System.Windows.Forms.TextBox txtPosY;
        private System.Windows.Forms.TextBox txtContador;
        private System.Windows.Forms.Button btnSeleccionarColor;
        private System.Windows.Forms.Button btnDibujar;
        private System.Windows.Forms.PictureBox pictureBoxColor;
        private System.Windows.Forms.Panel panelDibujo;

        private void InitializeComponent()
        {
            this.Text = "Dibujar Rectángulos";
            this.Size = new System.Drawing.Size(400, 500);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;

            // Etiqueta para Posición X
            lblPosX = new System.Windows.Forms.Label();
            lblPosX.Text = "Posición X:";
            lblPosX.Location = new System.Drawing.Point(20, 20);
            lblPosX.AutoSize = true;
            this.Controls.Add(lblPosX);

            // Caja de texto para Posición X
            txtPosX = new System.Windows.Forms.TextBox();
            txtPosX.Location = new System.Drawing.Point(100, 18);
            txtPosX.Size = new System.Drawing.Size(80, 25); // Aumenté el tamaño
            txtPosX.Font = new System.Drawing.Font("Arial", 10);
            txtPosX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Controls.Add(txtPosX);

            // Etiqueta para Posición Y
            lblPosY = new System.Windows.Forms.Label();
            lblPosY.Text = "Posición Y:";
            lblPosY.Location = new System.Drawing.Point(20, 60);
            lblPosY.AutoSize = true;
            this.Controls.Add(lblPosY);

            // Caja de texto para Posición Y
            txtPosY = new System.Windows.Forms.TextBox();
            txtPosY.Location = new System.Drawing.Point(100, 58);
            txtPosY.Size = new System.Drawing.Size(80, 25);
            txtPosY.Font = new System.Drawing.Font("Arial", 10);
            txtPosY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Controls.Add(txtPosY);

            // Etiqueta para contador de rectángulos
            lblContador = new System.Windows.Forms.Label();
            lblContador.Text = "Rectángulos creados:";
            lblContador.Location = new System.Drawing.Point(20, 100);
            lblContador.AutoSize = true;
            this.Controls.Add(lblContador);

            // Caja de texto para contador (solo lectura)
            txtContador = new System.Windows.Forms.TextBox();
            txtContador.Location = new System.Drawing.Point(170, 98);
            txtContador.Size = new System.Drawing.Size(50, 25);
            txtContador.Font = new System.Drawing.Font("Arial", 10);
            txtContador.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            txtContador.ReadOnly = true;
            txtContador.Text = "0";
            this.Controls.Add(txtContador);

            // Botón para seleccionar color
            btnSeleccionarColor = new System.Windows.Forms.Button();
            btnSeleccionarColor.Text = "Seleccionar Color";
            btnSeleccionarColor.Location = new System.Drawing.Point(20, 140);
            btnSeleccionarColor.Size = new System.Drawing.Size(140, 30);
            btnSeleccionarColor.Click += new System.EventHandler(this.btnSeleccionarColor_Click);
            this.Controls.Add(btnSeleccionarColor);

            // Cuadro para mostrar el color seleccionado
            pictureBoxColor = new System.Windows.Forms.PictureBox();
            pictureBoxColor.Location = new System.Drawing.Point(180, 140);
            pictureBoxColor.Size = new System.Drawing.Size(50, 30);
            pictureBoxColor.BackColor = System.Drawing.Color.Black;
            pictureBoxColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(pictureBoxColor);

            // Botón para dibujar el rectángulo
            btnDibujar = new System.Windows.Forms.Button();
            btnDibujar.Text = "Dibujar Rectángulo";
            btnDibujar.Location = new System.Drawing.Point(20, 180);
            btnDibujar.Size = new System.Drawing.Size(160, 30);
            btnDibujar.Click += new System.EventHandler(this.btnDibujar_Click);
            this.Controls.Add(btnDibujar);

            // Panel para el área de dibujo
            panelDibujo = new System.Windows.Forms.Panel();
            panelDibujo.Location = new System.Drawing.Point(20, 230);
            panelDibujo.Size = new System.Drawing.Size(340, 200);
            panelDibujo.BackColor = System.Drawing.Color.White;
            panelDibujo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(panelDibujo);
        }
    }
}



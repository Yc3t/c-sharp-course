#r "System.Windows.Forms"
#r "System.Drawing"

using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Imaging;

// Create the main form
var form = new Form();
form.Text = "Image Converter";
form.Size = new Size(800, 600);

// Create UI controls
var imagenmostrada = new PictureBox();
imagenmostrada.SizeMode = PictureBoxSizeMode.Zoom;
imagenmostrada.Dock = DockStyle.Fill;

var seleccionabrir = new ComboBox();
seleccionabrir.Items.AddRange(new string[] { "*.bmp", "*.jpg", "*.emf", "*.exif", "*.gif", "*.jpeg", "*.png", "*.tiff", "*.wmf" });
seleccionabrir.Location = new Point(10, 10);

var seleccionguardar = new ComboBox();
seleccionguardar.Items.AddRange(new string[] { "*.bmp", "*.jpg", "*.emf", "*.exif", "*.gif", "*.jpeg", "*.png", "*.tiff", "*.wmf" });
seleccionguardar.Location = new Point(200, 10);

var abrir = new Button();
abrir.Text = "Open";
abrir.Location = new Point(10, 40);

var guardar = new Button();
guardar.Text = "Save";
guardar.Location = new Point(200, 40);

Bitmap imagen = null;

// Event handlers
abrir.Click += (sender, e) => {
    var ofd = new OpenFileDialog();
    ofd.Filter = seleccionabrir.Text + "|" + seleccionabrir.Text;
    if (ofd.Filter.Length > 1)
    {
        var dr = ofd.ShowDialog();
        if (dr == DialogResult.OK)
        {
            imagen = new Bitmap(ofd.FileName);
            imagenmostrada.Image = imagen;
        }
        else if (dr != DialogResult.Cancel)
        {
            MessageBox.Show("Error al abrir el archivo", "Error");
        }
    }
    else
    {
        MessageBox.Show("Debes seleccionar una opción para abrir una imagen", "Error");
    }
};

guardar.Click += (sender, e) => {
    var sfd = new SaveFileDialog();
    sfd.Filter = seleccionguardar.Text + "|" + seleccionguardar.Text;
    if (sfd.Filter.Length > 1 && imagen != null)
    {
        var dr = sfd.ShowDialog();
        if (dr == DialogResult.OK)
        {
            String opcion = seleccionguardar.Text;
            switch (opcion) {
                case "*.bmp":
                    imagen.Save(sfd.FileName, ImageFormat.Bmp);
                    break;
                case "*.jpg":
                case "*.jpeg":
                    imagen.Save(sfd.FileName, ImageFormat.Jpeg);
                    break;
                case "*.emf":
                    imagen.Save(sfd.FileName, ImageFormat.Emf);
                    break;
                case "*.exif":
                    imagen.Save(sfd.FileName, ImageFormat.Exif);
                    break;
                case "*.gif":
                    imagen.Save(sfd.FileName, ImageFormat.Gif);
                    break;
                case "*.png":
                    imagen.Save(sfd.FileName, ImageFormat.Png);
                    break;
                case "*.tiff":
                    imagen.Save(sfd.FileName, ImageFormat.Tiff);
                    break;
                case "*.wmf":
                    imagen.Save(sfd.FileName, ImageFormat.Wmf);
                    break;
            }
            MessageBox.Show("Imagen convertida exitosamente", "Imagen convertida");
        }
        else if (dr != DialogResult.Cancel)
        {
            MessageBox.Show("Error al guardar el archivo", "Error");
        }
    }
    else
    {
        MessageBox.Show("Debes seleccionar una opción de guardado y tener una imagen abierta", "Error");
    }
};

// Add controls to form
form.Controls.AddRange(new Control[] { imagenmostrada, seleccionabrir, seleccionguardar, abrir, guardar });

// Run the application
Application.Run(form);
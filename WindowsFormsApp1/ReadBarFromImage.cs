using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Imaging;

using ZXing;
using ZXing.Common;
using ZXing.PDF417;

namespace WindowsFormsApp1
{
    internal class ReadBarFromImage
    {
        public static string ReadBarCodeFromImage(string imagePath)
        {
            try
            {
                /*string image = "C:\\Users\\myadr\\OneDrive\\Documentos\\GitHub\\CSharp_Projects\\CSharp_Projects\\WindowsFormsApp1\\bin\\Debug\\codbars\\IMG_20240605_121402597.jpg";*/
                

                Bitmap bitmap = (Bitmap)Image.FromFile(imagePath);
                
                BarcodeReader reader = new BarcodeReader
                {
                    AutoRotate = true,
                    Options = new ZXing.Common.DecodingOptions
                    {
                        PossibleFormats = null
                    }
                };

                // Ler o código de barras a partir da imagem
                var result = reader.Decode(bitmap);
                if (result != null)
                {
                    return result.Text;
                }
                else
                {
                    MessageBox.Show("Não foi possivel identificar o código de barras. Tente novamente!");
                    return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Exception: {ex.Message}");
                throw;
            }
        }
    
        

        public static string GetCodBarFromImage(OpenFileDialog openFileDialog1)
        {
            openFileDialog1.Title = "Selecione imagem do código de barras";
            openFileDialog1.Filter = "Arquivos de Imagem|*.jpg;*.jpeg;*.png;";
            DialogResult resultDialog = openFileDialog1.ShowDialog();
            if (resultDialog == DialogResult.OK)
            {
                try
                {
                    /*string caminhoCelular = @"Este Computador\moto g22\Armazenamento interno compartilhado\DCIM\Camera\IMG_20240604_162952057.jpg";*/
/*                    string destinationPath = Path.Combine(Application.StartupPath, "codbars");
                    string destinationFileName = Path.GetFileName(path);
                    string destinationFilePath = Path.Combine(destinationPath, destinationFileName);*/
/*                    if (!Directory.Exists(destinationPath))
                    {
                        Directory.CreateDirectory(destinationPath);
                    }
                    if (File.Exists(destinationFilePath))
                    {
                        FileInfo fileInfo = new FileInfo(destinationFilePath);
                        fileInfo.Attributes = FileAttributes.Normal;
                    }*/
                    /*File.Copy(path, destinationFilePath, true);*/
                    string path = openFileDialog1.FileName;
                    /*string diretorio = Path.GetDirectoryName(path);*/
                    /*MessageBox.Show(diretorio);*/
                    string codbar = ReadBarFromImage.ReadBarCodeFromImage(path);
                    return codbar;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    throw;
                }
            }
            else
            {
                return null;
            }
        }

        public static string ExtractDate(string codbar)
        {
            /*            int index = codbar.IndexOf("(17)");
                        if (index == -1) return "Erro";
                        string data = codbar.Substring(index, 6);*/
            MessageBox.Show(codbar);
            string dateTime = DateTime.ParseExact(codbar, "yyMMdd", null).ToString("dd/MM/yyyy");
            return dateTime/*DateTime.ParseExact(data, "yy/MM/dd", null).ToString("dd/MM/yyyy")*/;
        }
    }
}

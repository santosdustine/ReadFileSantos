using System.IO;

namespace ReadFileSantos
{
    public partial class FrmOpenTextFile : Form
    {
        public FrmOpenTextFile()
        {
            InitializeComponent();
        }
        private void DisplayToList()
        {
            openFileDialog1.InitialDirectory = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                "LastName_FirstName_LabStream");     // ← your real name
            openFileDialog1.Title = "Browse Text Files";
            openFileDialog1.DefaultExt = "txt";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

            if (openFileDialog1.ShowDialog() != DialogResult.OK) return;

            string path = openFileDialog1.FileName;
            lvShowText.Items.Clear();

            try
            {
                using (StreamReader streamReader = File.OpenText(path))
                {
                    string _getText = "";
                    while ((_getText = streamReader.ReadLine()) != null)
                    {
                        Console.WriteLine(_getText);
                        lvShowText.Items.Add(_getText);
                    }
                }
                if (lvShowText.Items.Count == 0)
                    throw new EmptyFileException();
            }
            catch (EmptyFileException ex)
            {
                MessageBox.Show(ex.Message, "Empty File");
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("The file was not found.", "Error");
            }
            catch (IOException ex)
            {
                MessageBox.Show("Cannot read the file: " + ex.Message, "Error");
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            DisplayToList();
        }
    }
    public class EmptyFileException : Exception
    {
        public EmptyFileException() : base("The selected file is empty.") { }
    }
}

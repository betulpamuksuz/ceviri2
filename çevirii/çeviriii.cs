using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TranslateApp
{
    public partial class MainForm : Form
    {
        // SQL bağlantı dizesi
        private string _connectionString = "Server=YOUR_SERVER_NAME;Database=YOUR_DATABASE_NAME;Trusted_Connection=True;";

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Dillerin ComboBox'lara eklenmesi
            PopulateLanguageComboboxes();
            // Verileri yükleme
            LoadTranslationHistory();
        }

        private void PopulateLanguageComboboxes()
        {
            var languages = new[] { "Türkçe", "İngilizce", "Almanca" };
            cmbSourceLanguage.Items.AddRange(languages);
            cmbTargetLanguage.Items.AddRange(languages);
        }

        private void btnTranslate_Click(object sender, EventArgs e)
        {
            if (!IsValidInput())
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Çeviriyi gerçekleştirme
            string translatedText = PerformTranslation(txtInput.Text);

            // Çeviriyi çıktıya yaz
            txtOutput.Text = translatedText;

            // Çeviriyi SQL'e kaydet
            SaveTranslation(txtInput.Text, translatedText, cmbTargetLanguage.SelectedItem.ToString());

            // Verileri yeniden yükle
            LoadTranslationHistory();
        }

        private bool IsValidInput()
        {
            return !string.IsNullOrEmpty(txtInput.Text) && cmbSourceLanguage.SelectedItem != null && cmbTargetLanguage.SelectedItem != null;
        }

        private string PerformTranslation(string sourceText)
        {
            // Burada gerçek bir çeviri algoritması yerine metni ters çevirdim.
            // Gerçek çeviri işlemi burada yapılabilir.
            return ReverseText(sourceText);
        }

        private string ReverseText(string text)
        {
            // Basit bir örnek çeviri: metni tersine çevirmek
            char[] charArray = text.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }

        private void ClearInputs()
        {
            txtInput.Clear();
            txtOutput.Clear();
            cmbSourceLanguage.SelectedIndex = -1;
            cmbTargetLanguage.SelectedIndex = -1;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoadTranslationHistory()
        {
            try
            {
                using (var con = new SqlConnection(_connectionString))
                {
                    con.Open();
                    string query = "SELECT * FROM Translations";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veriler yüklenirken bir hata oluştu: " + ex.Message);
            }
        }

        private void SaveTranslation(string sourceText, string translatedText, string targetLanguage)
        {
            try
            {
                using (var con = new SqlConnection(_connectionString))
                {
                    con.Open();
                    string query = "INSERT INTO Translations (SourceText, TranslatedText, Language) VALUES (@SourceText, @TranslatedText, @Language)";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@SourceText", sourceText);
                        cmd.Parameters.AddWithValue("@TranslatedText", translatedText);
                        cmd.Parameters.AddWithValue("@Language", targetLanguage);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Çeviri kaydedilirken bir hata oluştu: " + ex.Message);
            }
        }
    }
}

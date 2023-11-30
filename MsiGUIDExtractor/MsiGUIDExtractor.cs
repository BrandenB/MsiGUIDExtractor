/**
 * Author: Branden Brideau
 */

namespace MsiGUIDExtractor
{
    /// <summary>
    /// Class.
    /// </summary>
    public partial class MsiGUIDExtractor : Form
    {
        /// <summary>
        /// Class constructor.
        /// </summary>
        public MsiGUIDExtractor()
        {
            InitializeComponent();
        }

        /// <summary>
        /// On load event.
        /// </summary>
        /// <param name="sender">Sender of the event</param>
        /// <param name="e">Event arguments</param>
        private void MsiGUIDExtractor_Load(object sender, EventArgs e)
        {
            // Set our dialog box settings.
            fileDiag.CheckFileExists = true;
            fileDiag.Multiselect = false;
            fileDiag.DefaultExt = "msi";
            fileDiag.Title = "Choose MSI file";

            this.ActiveControl = this.applicatioNameTextBox;
        }

        /// <summary>
        /// When the file location textbox is focussed.
        /// </summary>
        /// <param name="sender">Sender of the event</param>
        /// <param name="e">Event arguments</param>
        private void msiFileLocationTextBox_Enter(object sender, EventArgs e)
        {
            DialogResult result = fileDiag.ShowDialog();

            if (result is DialogResult.OK)
            {
                msiFileLocationTextBox.Text = fileDiag.FileName;
            }
        }

        /// <summary>
        /// Extract button on click.
        /// </summary>
        /// <param name="sender">Sender of the event</param>
        /// <param name="e">Event arguments</param>
        private void extractFromFileBtn_Click(object sender, EventArgs e)
        {
            
        }
    }
}
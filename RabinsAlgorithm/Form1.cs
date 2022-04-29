using RabinsAlgorithm.domain;
using System.IO;
using System.Numerics;
using System.Text;

namespace RabinsAlgorithm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ApplyQAndPButton_Click(object sender, EventArgs e)
        {
            // Убираем лишние символы из TextBox - ов
            PTextBox.Text = ValuesChecker.ValidateTextBoxInput(PTextBox.Text);
            QTextBox.Text = ValuesChecker.ValidateTextBoxInput(QTextBox.Text);

            string pCheckResult = ValuesChecker.CheckTextBoxForInputErrors(PTextBox.Text, true);
            string qCheckResult = ValuesChecker.CheckTextBoxForInputErrors(QTextBox.Text, false, true, PTextBox.Text);

            if (pCheckResult != string.Empty)
            {
                pError.Text = pCheckResult;
                pError.ForeColor = Color.Red;
            }
            else
            {
                pError.Text = "None.";
                pError.ForeColor = Color.Green;
            }

            if (qCheckResult != string.Empty)
            {
                qError.Text = qCheckResult;
                qError.ForeColor = Color.Red;
            }
            else
            {
                qError.Text = "None.";
                qError.ForeColor = Color.Green;
            }

            if (pError.ForeColor == Color.Green && qError.ForeColor == Color.Green)
            {
                PTextBox.Enabled = false;
                QTextBox.Enabled = false;
                ApplyQAndPButton.Enabled = false;

                StartPrimalTestButton.Enabled = true;
            }
        }

        private void ClearAllButton_Click(object sender, EventArgs e)
        {
            PTextBox.Enabled = false;
            QTextBox.Enabled = false;
            ApplyQAndPButton.Enabled = false;

            PTextBox.Text = String.Empty;
            pError.Text = "None.";
            pError.ForeColor = Color.Black;

            QTextBox.Text = String.Empty;
            qError.Text = "None.";
            qError.ForeColor = Color.Black;

            StartPrimalTestButton.Enabled = false;

            PrimalTestResultLabel.Text = "None.";
            PrimalTestResultLabel.ForeColor = Color.Black;

            BTextBox.Text = String.Empty;
            BTextBox.Enabled = false;
            ApplyBButton.Enabled = false;
            bError.Text = "None.";
            bError.ForeColor = Color.Black;

            ContinueButton.Enabled = false;
            EncryptButton.Enabled = false;
            DecryptButton.Enabled = false;

            InputTextBox.Text = String.Empty;
        }

        private void StartPrimalTestButton_Click(object sender, EventArgs e)
        {
            if (!FermatsRadioButton.Checked && !MillersRabbinsRadioButton.Checked && !SympleCycleRadioButton.Checked)
            {
                PrimalTestResultLabel.Text = "Please, choose any of tests.";
                PrimalTestResultLabel.ForeColor = Color.Red;
                return;
            }
            else
            {
                if (FermatsRadioButton.Checked)
                {
                    try
                    {
                        BigInteger p = (BigInteger)Convert.ToDecimal(PTextBox.Text);
                        BigInteger q = (BigInteger)Convert.ToDecimal(QTextBox.Text);

                        bool pResult = ValuesChecker.IsPrimary_FermatsTest(p);
                        bool qResult = ValuesChecker.IsPrimary_FermatsTest(q);

                        if (!pResult && !qResult)
                        {
                            PrimalTestResultLabel.Text = "p And q Are Not Primal.";
                            PrimalTestResultLabel.ForeColor = Color.Red;
                            return;
                        }
                        if (pResult && !qResult)
                        {
                            PrimalTestResultLabel.Text = "p Is Primal And q Is Not Primal.";
                            PrimalTestResultLabel.ForeColor = Color.Red;
                            return;
                        }
                        if (!pResult && qResult)
                        {
                            PrimalTestResultLabel.Text = "p Is Not Primal And q Is Primal.";
                            PrimalTestResultLabel.ForeColor = Color.Red;
                            return;
                        }
                        if (pResult && qResult)
                        {
                            PrimalTestResultLabel.Text = "p And q Are Primal.";
                            PrimalTestResultLabel.ForeColor = Color.Green;

                            BTextBox.Enabled = true;
                            ApplyBButton.Enabled = true;

                            return;
                        }
                    }
                    catch (Exception ex)
                    {
                        string errorMssg = ex.Message;
                        PrimalTestResultLabel.Text = errorMssg;
                        PrimalTestResultLabel.ForeColor = Color.Red;
                        return;
                    }
                }

                if (MillersRabbinsRadioButton.Checked)
                {
                    try
                    {
                        BigInteger p = (BigInteger)Convert.ToDecimal(PTextBox.Text);
                        BigInteger q = (BigInteger)Convert.ToDecimal(QTextBox.Text);

                        bool pResult = ValuesChecker.IsPrimary_MillersRabinsTest(p, 10);
                        bool qResult = ValuesChecker.IsPrimary_MillersRabinsTest(q, 10);

                        if (!pResult && !qResult)
                        {
                            PrimalTestResultLabel.Text = "p And q Are Not Primal.";
                            PrimalTestResultLabel.ForeColor = Color.Red;
                            return;
                        }
                        if (pResult && !qResult)
                        {
                            PrimalTestResultLabel.Text = "p Is Primal And q Is Not Primal.";
                            PrimalTestResultLabel.ForeColor = Color.Red;
                            return;
                        }
                        if (!pResult && qResult)
                        {
                            PrimalTestResultLabel.Text = "p Is Not Primal And q Is Primal.";
                            PrimalTestResultLabel.ForeColor = Color.Red;
                            return;
                        }
                        if (pResult && qResult)
                        {
                            PrimalTestResultLabel.Text = "p And q Are Primal.";
                            PrimalTestResultLabel.ForeColor = Color.Green;

                            BTextBox.Enabled = true;
                            ApplyBButton.Enabled = true;

                            return;
                        }
                    }
                    catch (Exception ex)
                    {
                        string errorMssg = ex.Message;
                        PrimalTestResultLabel.Text = errorMssg;
                        PrimalTestResultLabel.ForeColor = Color.Red;
                        return;
                    }
                }

                if (SympleCycleRadioButton.Checked)
                {
                    try
                    {
                        BigInteger p = (BigInteger)Convert.ToDecimal(PTextBox.Text);
                        BigInteger q = (BigInteger)Convert.ToDecimal(QTextBox.Text);

                        bool pResult = ValuesChecker.IsPrimary_SympleCycleTest(p);
                        bool qResult = ValuesChecker.IsPrimary_SympleCycleTest(q);

                        if (!pResult && !qResult)
                        {
                            PrimalTestResultLabel.Text = "p And q Are Not Primal.";
                            PrimalTestResultLabel.ForeColor = Color.Red;
                            return;
                        }
                        if (pResult && !qResult)
                        {
                            PrimalTestResultLabel.Text = "p Is Primal And q Is Not Primal.";
                            PrimalTestResultLabel.ForeColor = Color.Red;
                            return;
                        }
                        if (!pResult && qResult)
                        {
                            PrimalTestResultLabel.Text = "p Is Not Primal And q Is Primal.";
                            PrimalTestResultLabel.ForeColor = Color.Red;
                            return;
                        }
                        if (pResult && qResult)
                        {
                            PrimalTestResultLabel.Text = "p And q Are Primal.";
                            PrimalTestResultLabel.ForeColor = Color.Green;

                            BTextBox.Enabled = true;
                            ApplyBButton.Enabled = true;

                            return;
                        }
                    }
                    catch (Exception ex)
                    {
                    string errorMssg = ex.Message;
                    PrimalTestResultLabel.Text = errorMssg;
                    PrimalTestResultLabel.ForeColor = Color.Red;
                    return;
                    }
                }
            }
        }

        private void ApplyBButton_Click(object sender, EventArgs e)
        {
            // Убираем лишние символы из TextBox - ов
            BTextBox.Text = ValuesChecker.ValidateTextBoxInput(BTextBox.Text);

            string bCheckResult = ValuesChecker.CheckTextBoxWithBForErrors(
                                                      BTextBox.Text,
                                                      (BigInteger)Convert.ToDecimal(PTextBox.Text),
                                                      (BigInteger)Convert.ToDecimal(QTextBox.Text));

            if (bCheckResult != string.Empty)
            {
                bError.Text = bCheckResult;
                bError.ForeColor = Color.Red;
            }
            else
            {
                bError.Text = "None.";
                bError.ForeColor = Color.Green;

                BTextBox.Enabled = false;
                ApplyBButton.Enabled = false;

                ContinueButton.Enabled = true;
                StartPrimalTestButton.Enabled = false;
            }
        }

        private void GetFileAsBytesButton_Click(object sender, EventArgs e)
        {
            FileContext.TakeBytesFromPath(PathTextBox.Text);

            if (FileContext.bufferByte == null)
                return;

            InputTextBox.Text = String.Join(Environment.NewLine, FileContext.bufferByte);

            PTextBox.Enabled = true;
            QTextBox.Enabled = true;
            ApplyQAndPButton.Enabled = true;
        }

        private void ContinueButton_Click(object sender, EventArgs e)
        {
            EncryptButton.Enabled = true;
            DecryptButton.Enabled = true;
        }

        private void EncryptButton_Click(object sender, EventArgs e)
        {
            if (FileContext.bufferByte == null)
                return;

            Encryptor.EncryptInput(FileContext.bufferByte, (BigInteger)Convert.ToDecimal(BTextBox.Text),
                                  (BigInteger)Convert.ToDecimal(PTextBox.Text) * (BigInteger)Convert.ToDecimal(QTextBox.Text));


            if (Encryptor.encryptedText == null)
                return;

            OutputTextBox.Text = String.Join(Environment.NewLine, Encryptor.encryptedText);

            SaveEncryptedButton.Enabled = true;
            SaveDecryptedButton.Enabled = true;
            SaveEncryptedAsTxt.Enabled = true;
        }

        // Запись последовательности байт в строку и сохранение как последовательность байт
        private void SaveEncryptedButton_Click(object sender, EventArgs e)
        {
            if (Encryptor.encryptedText == null)
                return;
            try
            {
                string bytesAsStr = "";
                for (int i = 0; i < Encryptor.encryptedText.Length; i++)
                {
                    bytesAsStr += Convert.ToChar((ulong)Encryptor.encryptedText[i]);
                }

            
                byte[] bytes = Encoding.Default.GetBytes(bytesAsStr);

                //using (Stream file = File.OpenWrite($@"{SaveFilePathTextBox.Text}"))
                using (Stream file = File.Create($@"{SaveFilePathTextBox.Text}"))
                {
                    file.Write(bytes, 0, bytes.Length);
                }

                MessageBox.Show("Saved successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to Save File As A Bytes Stream. Error: "+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        // Запись последовательности байт в строку и сохранение как строку байт
        private void SaveEncryptedAsTxt_Click(object sender, EventArgs e)
        {
            if (Encryptor.encryptedText == null)
                return;
            try
            {
                var digits = Encryptor.encryptedText;

                string bytesAsStr = "";
                for (int i = 0; i < digits.Length; i++)
                {
                    bytesAsStr += Convert.ToString(digits[i]);
                    bytesAsStr += " ";
                }
                bytesAsStr = bytesAsStr.Remove(bytesAsStr.Length - 1, 1);


                byte[] bytes = Encoding.Default.GetBytes(bytesAsStr);

                //using (Stream file = File.OpenWrite($@"{SaveFilePathTextBox.Text}"))
                using (Stream file = File.Create($@"{SaveFilePathTextBox.Text}"))
                {
                    file.Write(bytes, 0, bytes.Length);
                }

                MessageBox.Show("Saved successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to Save File As An String of Bytes. Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Чтение зашифрованного файла, в котором данные записаны как поток байтов
        private void RasdAsBytesEncryptedFile_Click(object sender, EventArgs e)
        {
            FileContext.TakeDigitsFromPathEncrypted(PathTextBox.Text);

            if (FileContext.bufferDigit == null)
                return;

            InputTextBox.Text = String.Join(Environment.NewLine, FileContext.bufferDigit);

            PTextBox.Enabled = true;
            QTextBox.Enabled = true;
            ApplyQAndPButton.Enabled = true;
        }

        private void GetFileAsASCIIButton_Click(object sender, EventArgs e)
        {
            FileContext.TakeASCIIFromPath(PathTextBox.Text);

            if (FileContext.bufferDigit == null)
                return;

            InputTextBox.Text = String.Join(Environment.NewLine, FileContext.bufferDigit);
        }

        private void DecryptButton_Click(object sender, EventArgs e)
        {
            Decryptor.DecryptMessage((BigInteger)Convert.ToDecimal(PTextBox.Text),
                                     (BigInteger)Convert.ToDecimal(QTextBox.Text),
                                     (BigInteger)Convert.ToDecimal(BTextBox.Text));

            if (Decryptor.decryptedBytes == null)
                return;

            OutputTextBox.Text = String.Join(Environment.NewLine, Decryptor.decryptedBytes);

            SaveDecryptedButton.Enabled = true;
        }

        private void SaveDecryptedButton_Click(object sender, EventArgs e)
        {
            if (Decryptor.decryptedBytes == null)
                return;
            try
            {

                using (Stream file = File.Create($@"{SaveFilePathTextBox.Text}"))
                {
                    file.Write(Decryptor.decryptedBytes, 0, Decryptor.decryptedBytes.Length);
                }

                MessageBox.Show("Saved successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to Save File As A Bytes Stream. Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
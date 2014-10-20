using System.Collections.Generic;
using System.Net.Mime;
using System.Windows;
using System.Windows.Input;
using XkPassword.PublicExtensionMethods;

namespace XkPassword.Demo
{
    /// <summary>
    ///     Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly XkPasswd _generator;

        public MainWindow()
        {
            this.InitializeComponent();
            _generator = new XkPasswd();
        }

        private void btnGenerate_Click(object sender, RoutedEventArgs e)
        {
            var replacements = new Dictionary<char, char>();
            if ((tbReplaceCharacters.Text.Length > 0) && (tbWithCharacters.Text.Length > 0))
            {
                if (tbReplaceCharacters.Text.Length < tbWithCharacters.Text.Length)
                {
                    for (int i = 0; i < tbReplaceCharacters.Text.Length; i++)
                    {
                        replacements.Add(tbReplaceCharacters.Text[i], tbWithCharacters.Text[i]);
                    }
                }
                else
                {
                    for (int i = 0; i < tbWithCharacters.Text.Length; i++)
                    {
                        replacements.Add(tbReplaceCharacters.Text[i], tbWithCharacters.Text[i]);
                    }
                }
            }

            if (string.IsNullOrWhiteSpace(tbPadLength.Text))
            {
                tbPadLength.Text = "0";
            }

            this._generator.SeparatorCharacter = (string.IsNullOrEmpty(this.tbSeparator.Text)
                                                      ? null
                                                      : (char?)(this.tbSeparator.Text[0]));
            this._generator.WordCount = int.Parse(this.tbWordCount.Text);
            this._generator.MinWordLength = int.Parse(this.tbMinWordLength.Text);
            this._generator.MaxWordLength = int.Parse(this.tbMaxWordLength.Text);
            this._generator.PaddingType = (Padding)(this.cbPaddingType.SelectedIndex);
            this._generator.PaddingCharacter = (string.IsNullOrEmpty(this.tbPaddingChar.Text)
                                                    ? null
                                                    : (char?)this.tbPaddingChar.Text[0]);
            this._generator.PaddingCharactersBefore = int.Parse(this.tbPadCharsBefore.Text);
            this._generator.PaddingCharactersAfter = int.Parse(this.tbPadCharsAfter.Text);
            this._generator.PaddingDigitsBefore = int.Parse(this.tbPadBefore.Text);
            this._generator.PaddingDigitsAfter = int.Parse(this.tbPadAfter.Text);
            this._generator.PadToLength = int.Parse(this.tbPadLength.Text);
            this._generator.CaseTransform = (CaseTransformation)(this.cbCaseTransform.SelectedIndex);
            this._generator.CharacterSubstitutions = replacements;

            _generator.SymbolAlphabet.FromCharArray((string.IsNullOrEmpty(this.tbSymbolAlphabet.Text)
                                                                  ? null
                                                                  : this.tbSymbolAlphabet.Text.ToCharArray()));
            _generator.SeparatorAlphabet.FromCharArray((string.IsNullOrEmpty(this.tbSymbolAlphabet.Text)
                                                                  ? null
                                                                  : this.tbSymbolAlphabet.Text.ToCharArray()));
            this.tbPasswords.Text += _generator.Generate() + '\n';
            this.tbPasswords.ScrollToEnd();
        }

        private void tbMinWordLength_KeyUp(object sender, KeyEventArgs e)
        {
            int x;
            if (!int.TryParse(this.tbMinWordLength.Text, out x))
            {
                this.tbMinWordLength.Text = "0";
            }
        }

        private void tbMaxWordLength_KeyUp(object sender, KeyEventArgs e)
        {
            int x;
            if (!int.TryParse(this.tbMaxWordLength.Text, out x))
            {
                this.tbMaxWordLength.Text = "0";
            }
        }

        private void tbPadDigitsBefore_KeyUp(object sender, KeyEventArgs e)
        {
            int x;
            if (!int.TryParse(this.tbPadBefore.Text, out x))
            {
                this.tbPadBefore.Text = "0";
            }
        }

        private void tbPadDigitsAfter_KeyUp(object sender, KeyEventArgs e)
        {
            int x;
            if (!int.TryParse(this.tbPadAfter.Text, out x))
            {
                this.tbPadAfter.Text = "0";
            }
        }

        private void tbPadCharsBefore_KeyUp(object sender, KeyEventArgs e)
        {
            int x;
            if (!int.TryParse(this.tbPadCharsBefore.Text, out x))
            {
                this.tbPadCharsBefore.Text = "0";
            }
        }

        private void tbPadCharsAfter_KeyUp(object sender, KeyEventArgs e)
        {
            int x;
            if (!int.TryParse(this.tbPadCharsAfter.Text, out x))
            {
                this.tbPadCharsAfter.Text = "0";
            }
        }

        private void tbPadLength_KeyUp(object sender, KeyEventArgs e)
        {
            int x;
            if (!int.TryParse(this.tbPadLength.Text, out x))
            {
                this.tbPadLength.Text = "0";
            }
        }

        private void tbNumWords_KeyUp(object sender, KeyEventArgs e)
        {
            int x;
            if (!int.TryParse(this.tbWordCount.Text, out x))
            {
                this.tbWordCount.Text = "4";
            }
        }
    }
}
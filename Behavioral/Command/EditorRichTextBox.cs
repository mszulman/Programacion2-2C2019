using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace Command
{
    public class EditorRichTextBox : RichTextBox
    {
        public EditorRichTextBox()
        {
        }

        public void Negrita()
        {
            this.Font = new System.Drawing.Font(this.Font, this.Font.Style | FontStyle.Bold);
        }
        public void SacarNegrita()
        {
            this.Font = new System.Drawing.Font(this.Font, this.Font.Style & ~FontStyle.Bold);
        }
        public void Italica()
        {
            this.Font = new System.Drawing.Font(this.Font, this.Font.Style | FontStyle.Italic);
        }
        public void SacarItalica()
        {
            this.Font = new System.Drawing.Font(this.Font, this.Font.Style & ~FontStyle.Italic);
        }
        public void Subrayado()
        {
            this.Font = new System.Drawing.Font(this.Font, this.Font.Style | FontStyle.Underline);
        }
        public void SacarSubrayado()
        {
            this.Font = new System.Drawing.Font(this.Font, this.Font.Style & ~FontStyle.Underline);
        }
        public void AumentarTamanio()
        {
            this.Font = new System.Drawing.Font(this.Font.FontFamily, this.Font.SizeInPoints + 1, this.Font.Style);
        }
        public void ReducirTamanio()
        {
            this.Font = new System.Drawing.Font(this.Font.FontFamily, this.Font.SizeInPoints - 1, this.Font.Style);
        }
    }
}

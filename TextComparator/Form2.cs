using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextComparator
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public string TextA;
        public string TextB;

        private void Form2_Load(object sender, EventArgs e)
        {
            ColorConverter colorConvertor = new ColorConverter();
            label1.BackColor = (Color)colorConvertor.ConvertFromString("#FBA8A8");
            label2.BackColor = (Color)colorConvertor.ConvertFromString("#72FBC5");
            var dmp = new DiffMatchPatch.diff_match_patch();
            var diff = dmp.diff_main(TextA, TextB);
            dmp.diff_cleanupSemantic(diff);

            webBrowser1.DocumentText = dmp.diff_prettyHtml(diff);
        }
    }
}

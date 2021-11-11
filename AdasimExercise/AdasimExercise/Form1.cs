using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdasimExercise
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnOpenFile_Click(object sender, EventArgs e)
        {
            try
            {
                var fileContent = string.Empty;
                var filePath = string.Empty;
                FileDetails fileDetails = null;

                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.InitialDirectory = "c:\\";
                    openFileDialog.Filter = "txt files (*.txt)|*.txt";
                    openFileDialog.RestoreDirectory = true;

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        filePath = openFileDialog.FileName;
                        var fileStream = openFileDialog.OpenFile();

                        using (StreamReader reader = new StreamReader(fileStream))
                        {
                            fileContent = reader.ReadToEnd();
                        }

                        fileDetails = new FileDetails(fileContent);
                    }
                }

                LblLinesCount.Text = "כמות השורות: " + fileDetails.GetLinesCount();
                LblWordsCount.Text = "כמות המילים: " + fileDetails.GetWordsCount();
                LblAvgSentenceLength.Text = "אורך משפט ממוצע: " + fileDetails.GetAvgSentenceLength();
                LblMaxSentenceLength.Text = "אורך משפט מקסימלי: " + fileDetails.GetMaxSentenceLength();
                LblUniqueWordsCount.Text = "כמות המילים הייחודיות: " + fileDetails.GetUniqueWordsCount();
                Dictionary<string, int> colors = fileDetails.GetColors();

                DataTable dt = new DataTable();
                dt.Columns.Add("צבע", typeof(string));
                dt.Columns.Add("כמות", typeof(int));
                colors.ToList().ForEach(kvp => dt.Rows.Add(new object[] { kvp.Key, kvp.Value }));

                dt.Constraints.Add("keyconstraint", dt.Columns[0], true);

                DGVColors.DataSource = dt;
                DGVColors.ClearSelection();

                LblMostPopularWord.Text = "המילה הפופולרית ביותר: " + fileDetails.GetMostPopularWord();

                Dictionary<string, int> characters = fileDetails.GetCharacters();
                List<string> list = characters.Select(k => k.Key).ToList();
                if (list.Count != 0)
                {
                    TbCharacters.Text = string.Join(", ", list);
                    LblMostPopularCharacter.Text = "הדמות הנפוצה ביותר: " + list.First();
                }
                else
                {
                    TbCharacters.Text = "לא נמצאו דמויות";
                    LblMostPopularCharacter.Text = "הדמות הנפוצה ביותר: -";
                }
                

            }
            catch
            {

            }
            

        }


    }
}

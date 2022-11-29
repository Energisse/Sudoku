using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sodoku
{
    //Class de sauvegarde
    internal class Sauvegarde
    {
        //Chemin des sauvegarde
        private static string chemin = System.Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "/SudokuHalvick/";
        //Sauvegarde l'etat du sudoku
        public static void Sauvegarder(Sudoku sudoku)
        {
            if (!Directory.Exists(chemin))
            {
                Directory.CreateDirectory(chemin);
            }
            File.WriteAllText(chemin + sudoku.DateTimeCreation + ".json", JsonConvert.SerializeObject(sudoku));
        }
        //Charge un sudoku par sa date de création
        public static Sudoku Charger(string dataTime)
        {
            if (!Directory.Exists(chemin))
            {
                Directory.CreateDirectory(chemin);
                //Pas de dossier, pas de sauvegarde donc fin.
                return null;
            }
            return JsonConvert.DeserializeObject<Sudoku>(File.ReadAllText(chemin+dataTime+".json"));
        }

        //Charge la liste des Sudoku
        public static JToken[] Charger()
        {
            if (!Directory.Exists(chemin))
            {
                Directory.CreateDirectory(chemin);
                //Pas de dossier, pas de sauvegarde donc fin.
                return new JToken[0];
            }

            string[] fichiersSauvegarde = Directory.GetFiles(chemin);
            JToken[] sauvegardes = new JToken[fichiersSauvegarde.Length];
            for (int i = 0; i < fichiersSauvegarde.Length; i++)
            {
                String result = File.ReadAllText(fichiersSauvegarde[i]);
                sauvegardes[i] = JsonConvert.DeserializeObject<JToken>(result.ToString());
            }
            return sauvegardes;
        }

        //Supprime un sudoku en fonction de sa date de création
        public static void Supprimer(string dateTime)
        {
            if (!Directory.Exists(chemin))
            {
                Directory.CreateDirectory(chemin);
                //Pas de dossier, pas de sauvegarde a effacer donc fin.
                return;
            }
            File.Delete(chemin + dateTime+".json");
        }
    }
}

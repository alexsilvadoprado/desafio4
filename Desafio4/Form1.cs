using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desafio4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAnalisar_Click(object sender, EventArgs e)
        {
            /** recebe o texto digitado */
            string frase = txbFrase.Text;

            /** string para receber a frequência das palavras */
            string textoFrequencia = "";

            if (string.IsNullOrEmpty(frase))
                return;

            /** Remove caracteres especiais e espaço no final da frase */
            frase = Regex.Replace(frase, "[^a-zA-Zà-úÀ-Ú0-9]+( ){2,}", "", RegexOptions.Compiled);
            frase = frase.EndsWith(" ") ? frase.Remove(frase.Length - 1) : frase;
            /** quebra a frase em palavras a partir dos espaços */
            string[] split = frase.Split(' ');

            /** dictionary de frequências */
            Dictionary<string, int> frequencia = new Dictionary<string, int>();

            /** verifica todas as palavras da frase */
            foreach (string key in split)
            {
                /** Se a palavra(chave) já existir no dicionário incrementa a sua frequência(valor), senão adiciona-a com frequência 1 */
                if (frequencia.ContainsKey(key))
                {
                    frequencia[key]++;
                }
                else
                {
                    frequencia.Add(key, 1);
                }
            }

            /** Percorre o dicionário acrescentando a frequência das palavras na string */
            foreach (var item in frequencia)
            {
                textoFrequencia += string.Format("{0}[{1}];{2}", item.Key, item.Value, Environment.NewLine);
            }

            /** exibe a Frequência das palavras */
            txbFrequencia.Text = textoFrequencia;
        }
    }
}

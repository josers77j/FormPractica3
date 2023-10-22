using BussinesLayer.Crud;
using CommonLayer.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pruebaCrud.Forms
{
    public partial class CharactersForms : Form
    {
        public CharactersForms()
        {
            InitializeComponent();
            LoadCharacterGridView();
        }

        public void LoadCharacterGridView()
        {

            CharacterBussines characterBussines = new CharacterBussines();
            characterDataGridView.DataSource= characterBussines.getCharacters();

        }

        private void guardarButton_Click(object sender, EventArgs e)
        {
            Character character = new Character();  
            CharacterBussines characterBussines =new CharacterBussines();   

            character.nombre = nombreTextbox.Text;
            character.ataque = int.Parse(ataqueTextbox.Text);
            character.defensa = int.Parse(defensaTextbox.Text);
            character.ki = int.Parse(kiTextbox.Text);

            characterBussines.addCharacter(character);
            LoadCharacterGridView();
        }

        private void characterDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (characterDataGridView.SelectedRows.Count > 0)
            {
                nombreTextbox.Text = characterDataGridView.CurrentRow.Cells["nombre"].Value.ToString();
                ataqueTextbox.Text = characterDataGridView.CurrentRow.Cells["ataque"].Value.ToString();
                defensaTextbox.Text = characterDataGridView.CurrentRow.Cells["defensa"].Value.ToString();
                kiTextbox.Text = characterDataGridView.CurrentRow.Cells["ki"].Value.ToString();
            }
            {

            }
        }
    }
}
